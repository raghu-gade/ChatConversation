import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { ApiService } from '../api.service';
@Injectable({
  providedIn: 'root'
})
export class ChatService {
accessToken:string
//userName:string
  constructor(private http:HttpClient, public apiServc: ApiService) { }

  private url = "https://localhost:7141/api/";

  userName:BehaviorSubject<string> = new BehaviorSubject('');

  setUsername(text:string){
    this.userName.next(text);
  }

  getToken(name:string): Observable<any>{
    debugger

    return this.http.get(this.url + 'Chat?name=' +name);

  }
  GetChatAccessToken_Completed(r){
    return r;
  }
  GetChatAccessToken_ErrorRaised(e) { }
  getConversationList(): Observable<any> {
    return this.http.get(this.url + 'Chat/GetAllConversations');
  }
  getMessagesByConvId(id:any):Observable<any> {
    return this.http.get(this.url + 'Chat/GetMessagesByConversationId?ConversationId='+id);
  }

}


