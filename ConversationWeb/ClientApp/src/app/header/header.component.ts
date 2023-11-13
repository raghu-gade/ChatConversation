import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import * as $ from 'jquery';
import { Subscription } from 'rxjs';
import { ChatService } from '../chats/chat.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  title = 'twilio-chat-example';
  userName:string = '';
  enableChat:boolean = false;
  $nameSubscriber:Subscription;

  constructor(
    private chatService:ChatService
  ){
    this.$nameSubscriber = this.chatService.userName.subscribe( name => this.userName = name);
  }

  ngOnInit(): void {

  }

  setName(){
    this.chatService.setUsername(this.userName);
    this.enableChat = true;
  }

  logout(){
    this.chatService.setUsername('');
    this.enableChat = false;
  }

  ngOnDestroy(): void {
    if(this.$nameSubscriber) this.$nameSubscriber.unsubscribe();
  }
}
