import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { resources } from 'Models/resources';
import { Observable } from '../../node_modules/rxjs/dist/types/index';

@Injectable({
  providedIn: 'root'
})
export class ResourceService {
token=localStorage.getItem('token');
  hosturl="http://hotstar-2445-stuti-Api.radixind.in/api";
  constructor(private http:HttpClient) { }
  post(resource:any){
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization:`Bearer ${this.token}`

      })
    }
    return this.http.post<any>(this.hosturl+'/Resource', resource, httpOptions);
  }

  get():Observable<Array<resources>>{
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization:`Bearer ${this.token}`

      })
    }
    var call= this.http.get<Array<resources>>(this.hosturl+'/Resource', httpOptions);
    return call;
  }

  put(resource:resources, id:number):Observable<resources> 
  {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization:`Bearer ${this.token}`

      })
    }
    return this.http.put<resources>(`${this.hosturl}/Resource/${id}`,resource,httpOptions)
  }
  delete(id:number): Observable<any> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization:`Bearer ${this.token}`

      })
    }
    return this.http.delete<any>(`/resource/${id}`,httpOptions);
  }
}
