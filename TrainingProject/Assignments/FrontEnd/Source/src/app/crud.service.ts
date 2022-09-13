import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from '../../node_modules/rxjs/dist/types/index';
import { content } from '../../Models/content';

@Injectable({
  providedIn: 'root'
})
export class CrudService {
  token=localStorage.getItem('token');
  hosturl = "http://hotstar-2445-stuti-Api.radixind.in/api";

  constructor(private http: HttpClient) {

  }
  getContent(): Observable<Array<content>> {
    var call = this.http.get<Array<content>>(this.hosturl + "/Content");
    return call;
  }
putcontent(content:content, id:number):Observable<content>{
  const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
      Authorization:`Bearer ${this.token}`

    })
  }
  return this.http.put<content>(`${this.hosturl}/content/${id}`,content,httpOptions)
}
  
}
