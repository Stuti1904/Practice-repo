import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from '../../node_modules/rxjs/dist/types/index';
@Injectable({
  providedIn: 'root'
})
export class CommentService {
hosturl="http://hotstar-2445-stuti-Api.radixind.in/api";
token=localStorage.getItem('token');
  constructor(private http:HttpClient) { }
  getById(id:number): Observable<Array<any>>{
var call=this.http.get<Array<any>>(`${this.hosturl}/comment/${id}`);
return call;
  }

  postcomment(comment:any){
    debugger
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization:`Bearer ${this.token}`
      })
    }
    return this.http.post<any>(`${this.hosturl}/comment`, comment, httpOptions);
  }
}
