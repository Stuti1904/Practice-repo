import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
hosturl="http://hotstar-2445-stuti-Api.radixind.in/api/Login"
  constructor(private http:HttpClient) { }

  loginuser(user:any){
    console.log(this.http.post<any>(this.hosturl,user));
    return this.http.post<any>(this.hosturl,user);
  }
}
