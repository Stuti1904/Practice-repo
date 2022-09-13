import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-subscribe',
  templateUrl: './subscribe.component.html',
  styleUrls: ['./subscribe.component.css']
})
export class SubscribeComponent implements OnInit {
show=true;
  constructor() { }

  ngOnInit(): void {
  }
check(){
  this.show=false;
}
uncheck(){
  this.show=true;
}
}
