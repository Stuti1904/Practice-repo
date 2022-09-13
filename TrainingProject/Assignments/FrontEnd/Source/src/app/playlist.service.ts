import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AdminUserServiceService } from './admin-user-service.service';
import { Observable } from '../../node_modules/rxjs/dist/types/index';
@Injectable({
  providedIn: 'root'
})
export class PlaylistService {
  hosturl = "http://hotstar-2445-stuti-Api.radixind.in/api";
  token=localStorage.getItem('token')||'';
  constructor(private http:HttpClient) { }
getByUserId(userId:number)
 {
var temp=this.http.get<any>(`${this.hosturl}/playlist/${userId}`);
return temp;
}

post(playlist:any){
  const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
      Authorization:`Bearer ${this.token}`

    })
  }
  return this.http.post<any>(`${this.hosturl}/playlist`, playlist, httpOptions);
}

delete(id:number){
  return this.http.delete<any>(`${this.hosturl}/playlist/${id}`);
}
}

