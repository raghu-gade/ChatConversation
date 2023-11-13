import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ServerconfigService {
  public ServiceUrls:any;
  constructor(public http:HttpClient) {
  }
    //  loadAuthConfig() {
    // return this.http.get('app/config/authconfig.json').toPromise().then(x => this.authconfig = x);
    // }

  // getAuthConfig() {
  //   return this.authconfig;
  // }


  loadConfig(): Promise<any>{
    return this.http.get('app/config/serverconfig.json').toPromise()
    .then(res =>
      {debugger
      this.ServiceUrls = res})
    .catch(err=>console.log("base url server configuration not found."));
  }
   getBaseUrl = function(code:string){
     return this.ServiceUrls[code] ?
     this.ServiceUrls[code].baseurl :
     this.ServiceUrls['local'].baseurl;
   }


}
