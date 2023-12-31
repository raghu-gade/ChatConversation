import { AfterViewChecked, Component, ElementRef, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { Client, ConnectionState, Conversation, Message, Participant } from '@twilio/conversations';
import { ChatService } from './chat.service';
import { Subscription } from 'rxjs';
import { Conversations } from '../models/conversation';

@Component({
  selector: 'app-chats',
  templateUrl: './chats.component.html',
  styleUrls: ['./chats.component.css']
})
export class ChatsComponent implements  OnInit, OnDestroy, AfterViewChecked {

  userName: string;
  client: Client;
  $nameSubscriber: Subscription;
  isLoading: boolean;
  newUser: string;
  newChatModal:boolean= false

  chatList=[];
  messages: Array<Message> = [];
  message: string;
  error: string;
  currentConversation: Conversation;

  isTyping: boolean;
  currentTime: Date;
  token:any
  @ViewChild('chatBox') private myScrollContainer: ElementRef;

  constructor(
    private chatService: ChatService
  ) {
    debugger
    this.$nameSubscriber = this.chatService.userName.subscribe(name => this.userName = name);
  }

  ngOnInit(): void {
    this.currentTime = new Date();
    this.connectTwilio();

  }

  connectTwilio() {
    this.isLoading = true;
    this.chatService.getToken(this.userName).subscribe(
         (data:any) =>{
        debugger
        this.token= data.item1;
        this.CallRedirect();
     },
  )
 }

  // listenToEvents() {
  //   this.client.on('initialized', () => {
  //     console.log('Client initialized');
  //     this.fetchUserChats();
  //   });

  //   this.client.on('initFailed', (error: any) => {
  //     console.log('Client initialization failed: ', error);
  //   });

  //   this.client.on('connectionStateChanged', (state: ConnectionState) => {
  //     console.log('Connection state change: ', state);
  //   });

  //   this.client.on('connectionError', (error: any) => {
  //     console.log('Connection error: ', error);
  //   });

  //   this.client.on('tokenAboutToExpire', () => {
  //     console.log('About to expire');
  //     // this.getToken().subscribe(async (token) => {
  //     //   this.client = await this.client.updateToken(token);
  //     // })
  //   });

  //   this.client.on('tokenExpired', () => {
  //     console.log('Token expired');
  //     this.client.removeAllListeners();
  //     this.connectTwilio();
  //   });

  //   this.client.on('conversationAdded', (conv: Conversation) => {
  //     setTimeout(async () => {
  //       if (conv.dateCreated && conv.dateCreated > this.currentTime) {
  //         console.log('Conversation added', conv);
  //         await conv.setAllMessagesUnread();
  //         let newChat = {
  //           chat: conv,
  //           unreadCount: 0,
  //           lastMessage: ''
  //         }
  //         //this.chatList = [newChat,...this.chatList];
  //       }
  //     }, 500);
  //   });

  //   this.client.on('messageAdded', async (msg: Message) => {
  //     console.log('Message added', msg);
  //     if (this.currentConversation && this.currentConversation.sid === msg.conversation.sid) {
  //       this.messages.push(msg);
  //       await this.currentConversation.updateLastReadMessageIndex(msg.index);
  //       this.chatList = this.chatList.map(el => {
  //         if(el.chat.sid === this.currentConversation.sid){
  //           el.lastMessage = msg.body;
  //         }
  //         return el;
  //       });
  //     } else {
  //       this.chatList = this.chatList.map(el => {
  //         if(el.chat.sid === msg.conversation.sid){
  //           el.lastMessage = msg.body;
  //           el.unreadCount++;
  //         }
  //         return el;
  //       });
  //     }
  //   });

  //   this.client.on('typingStarted', (user: Participant) => {
  //     console.log('typing..', user);
  //     if (user.conversation.sid === this.currentConversation.sid) this.isTyping = true;
  //   });

  //   this.client.on('typingEnded', (user: Participant) => {
  //     console.log('typing end..', user);
  //     if (user.conversation.sid === this.currentConversation.sid) this.isTyping = false;
  //   });
  // }

  fetchUserChats() {
    this.isLoading = true;
    debugger
    this.client.getSubscribedConversations().then(convs => {
      debugger
      let chats:any = [...convs.items];
      chats.forEach( async (chat:Conversation) => {
        let obj = {
          chat: chat,
          unreadCount: await chat.getUnreadMessagesCount(),
          lastMessage: (await chat.getMessages()).items[chat.lastReadMessageIndex || 0].body
        }
        //this.chatList.push(obj);
      })
      this.isLoading = false;
    }).catch(error => console.log(error));
  }

  sendMessage() {
    this.currentConversation.sendMessage(this.message).then(result => {
      this.message = '';
    }).catch(err => console.log(err));
  }
  openChatWindow() {
    this.newChatModal = true
  }
  closeChat() {
    this.newChatModal = false
  }
  newChat() {
    this.isLoading = true;
    this.client.getUser(this.newUser).then(res => {
      this.client.createConversation({
        friendlyName: `${this.newUser}-${this.userName}`,
      }).then(async (channel: Conversation) => {
        channel.join().then(async () => {
          await channel.setAllMessagesUnread();
          channel.add(this.newUser).then(() => {
            this.currentConversation = channel;
            this.openChat(channel);
            this.scrollToBottom();
            this.isLoading = false;
          })
        });
      }).catch(error => console.log(error));
    }).catch(err => {
      this.isLoading = false;
      this.error = 'User not found in Twilio';
      setTimeout(() => {
        this.error = null;
      }, 2000);
      this.newUser = null;
    });
  }

  openChat(e) {

    this.currentConversation = e;
    this.messages = [];
    this.fetchMessages(e);
  }

  fetchMessages(e) {

    this.isLoading = true;
    this.chatService.getMessagesByConvId(e.sid).subscribe({
      next: (data) => {
        debugger
        this.messages=data.messages
        this.isLoading = false;
      },
      error: (err: any) => {
       console.log(err);
      }
    })

    // this.currentConversation.getMessages(30, skip).then(async (result) => {
    //   this.messages = [...result.items, ...this.messages];
    //   if (!skip) {
    //     let resetTo = this.messages.length >= 1 ? this.messages[this.messages.length - 1].index : 0;
    //     await this.currentConversation.updateLastReadMessageIndex(resetTo);
    //     // this.chatList = this.chatList.map( el => {
    //     //   if(el.chat.sid == this.currentConversation.sid){
    //     //     el.unreadCount = 0;
    //     //   }
    //     //   return el;
    //     // })
    //   }
    //   this.isLoading = false;
    // }).catch(error => {
    //   this.isLoading = false;
    //   console.log(error)
    // });
  }

  loadMessages() {
    if (this.messages[0].index > 0) this.fetchMessages(this.messages[0].index - 1);
  }

  getToken() {
    // return this.chatService.getToken(this.userName)
    //   .map((result: Response) => result.json())
    //   .catch(this.getError);

      this.chatService.getToken(this.userName).subscribe(
        { next:(r:any) => {
        this.token= r;
this.CallRedirect();
      }
    })

  }
  CallRedirect(){
    if(this.token != null || this.token!= ''|| this.token != undefined)
    {
      // this.token => {
        debugger
        this.client = new Client(this.token);
        this.isLoading = false;
        this.getConversationsList()
        //this.listenToEvents();
      //}error => console.log(error);
    }
    else{
      error => console.log(error);
    }
  }
  getConversationsList(){
    this.isLoading=true
    this.chatService.getConversationList().subscribe({
      next: (data) => {
        debugger
        this.chatList=data.conversations
        this.isLoading = false;

      },
      error: (err: any) => {
       console.log(err);
      }
    })
  }

  ngAfterViewChecked() {
    this.scrollToBottom();
  }

  scrollToBottom(): void {
    try {
      this.myScrollContainer.nativeElement.scrollTop = this.myScrollContainer.nativeElement.scrollHeight;
    } catch (err) { }
  }

  ngOnDestroy(): void {
    if (this.$nameSubscriber) this.$nameSubscriber.unsubscribe();
    this.client.removeAllListeners();
    this.client.shutdown();
  }

}
