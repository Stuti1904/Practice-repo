import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Post } from './Models/Posts';
import { Observable, throwError } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class UserserviceService {

  hosturl="https://gorest.co.in/public/v2/";
  token="427933daeb1bf82071e7e923f95a7aa4d6e380474189675b4cdd41447ad71532";
  constructor(private http:HttpClient) { 

  }
  getUsers():Observable<Array<Post>>
  {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization:`Bearer ${this.token}`

      })
    }
  var call= this.http.get<Array<Post>>(`${this.hosturl}posts`,httpOptions) 
  return call;
   }

  postUser(user:Post)
  {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization:`Bearer ${this.token}`

      })
    }
   return this.http.post<Post>(`${this.hosturl}posts`,user,httpOptions)

  }
  putUser(user:Post,id:number):Observable<Post> 
  {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization:`Bearer ${this.token}`

      })
    }
      return this.http.put<Post>(`${this.hosturl}posts/${id}`,user,httpOptions)

    }
  }