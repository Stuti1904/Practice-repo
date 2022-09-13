import { Injectable } from '@angular/core';
import { Observable } from '../../node_modules/rxjs/dist/types/index';
import { adminCotent } from 'Models/adminContent';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { content } from 'Models/content';
@Injectable({
  providedIn: 'root'
})
export class ContentService {
  hosturl = "http://hotstar-2445-stuti-Api.radixind.in/api";
token=localStorage.getItem('token');
  constructor(private http: HttpClient) {

  }
  getContent(): Observable<Array<content>> {
    var call = this.http.get<Array<content>>(this.hosturl + "/Content");
    return call;
  }
  postContent(content:any){
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization:`Bearer ${this.token}`
  
      })
    }
    return this.http.post<any>(`${this.hosturl}/Content`, content, httpOptions);
  }

  put(content:any, id:number): Observable<any>
{
  const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
      Authorization:`Bearer ${this.token}`

    })
  }
  return this.http.put<any>(`${this.hosturl}/content/${id}`, content, httpOptions);
}

delete(id:number): Observable<any>{
  debugger
  const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
      Authorization:`Bearer ${this.token}`

    })
  }
  return this.http.delete<any>(`${this.hosturl}/content/${id}`, httpOptions)
}

getone(name:string):Observable<any>{
  debugger
  var call = this.http.get(`${this.hosturl}/content/${name}`);
  console.log(call);
  return call;
}
like(id:number){
  return this.http.put(`${this.hosturl}/content/like/${id}`, '');
}
dislike(id:number){
  return this.http.put(`${this.hosturl}/content/dislike/${id}`, '');
}
view(id:number){
  return this.http.put(`${this.hosturl}/content/view/${id}`, '')
}
}
