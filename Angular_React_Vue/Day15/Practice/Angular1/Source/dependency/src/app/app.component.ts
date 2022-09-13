import { Component } from '@angular/core';
import { GreetingService } from './greeting.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'dependency';
  name:string="";
  result: string="";
  constructor(private greet: GreetingService){

  }
  greeting(){
   this.result= "Greetings of the day"+ this.greet.greeting(this.name)
  }
}
