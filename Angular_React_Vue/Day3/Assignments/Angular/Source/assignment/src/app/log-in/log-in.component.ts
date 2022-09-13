import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
name:any='';
passWord: any= '';
answer:any='';
check(){
  if(this.name =="admin" && this.passWord =="admin"){
    this.answer="Logged In";
    console.log(this.answer);
  }
  else{
    this.answer="Not logged in"
    console.log(this.answer);
  }
}
}
