import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GreetingService {

  greeting(name:string){
    return name;
  }
  constructor() { }
}
