import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SingupService {
hosturl="http://hotstar-2445-stuti-Api.radixind.in/api/Signup";
  constructor(private http:HttpClient) { }
  postUser(user:any)
  {
    return this.http.post<any>(this.hosturl,user)

    }

}

