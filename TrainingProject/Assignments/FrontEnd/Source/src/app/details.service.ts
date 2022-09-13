import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { generalInfo } from 'Models/generalInfo';
import { Observable } from '../../node_modules/rxjs/dist/types/index';

@Injectable({
  providedIn: 'root'
})
export class DetailsService {

  hosturl = "http://hotstar-2445-stuti-Api.radixind.in/api";
  constructor(private http: HttpClient) { }

  getdetails(): Observable<Array<generalInfo>>{
    var call=this.http.get<Array<generalInfo>>(this.hosturl + "/VideoInfo");

    return call;
  }

}
