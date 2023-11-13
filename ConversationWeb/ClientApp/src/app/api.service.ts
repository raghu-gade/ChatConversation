import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ServerconfigService } from './serverconfig.service';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  constructor(public http: HttpClient, public serverconfig: ServerconfigService) { }

  public url1 = "https://localhost:7141/api/";
  GetChatAccessToken = function(url:string){
    return this.http.get( this.url1 + url);
   }
}
