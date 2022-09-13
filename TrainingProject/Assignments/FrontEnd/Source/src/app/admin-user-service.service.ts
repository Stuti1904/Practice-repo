import { Injectable } from '@angular/core';
import {adminUser} from '../../Models/adminUser';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from '../../node_modules/rxjs/dist/types/index';
@Injectable({
  providedIn: 'root'
})
export class AdminUserServiceService {
  token=localStorage.getItem('token');
  hostrul="http://hotstar-2445-stuti-Api.radixind.in/api"
  constructor(private http: HttpClient) { }
 
getadmin(): Observable<Array<adminUser>>{
  var admin= this.http.get<Array<adminUser>>(this.hostrul+ "/user");
  return admin;
}

getAllUsers():Observable<Array<any>>{
  var users = this.http.get<Array<any>>(this.hostrul+ "/user");
  return users;
}      

getroles():Observable<Array<any>>{
  var roles=this.http.get<Array<any>>(this.hostrul+'/role');
  return roles;
}

put(user:any, id:number): Observable<any>
{
  const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
      Authorization:`Bearer ${this.token}`

    })
  }
  return this.http.put<any>(`${this.hostrul}/User/${id}`, user, httpOptions);
}
delete(id:number):Observable<any> {
  const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
      Authorization:`Bearer ${this.token}`

    })
  }
  return this.http.delete<any>(`${this.hostrul}/User/${id}`, httpOptions);
}
getbyphone(phone:number): Observable<any>{
  return this.http.get<any>(`${this.hostrul}/User/${phone}`);
}
} 
