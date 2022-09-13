import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-rect-angle',
  templateUrl: './rect-angle.component.html',
  styleUrls: ['./rect-angle.component.css']
})
export class RectAngleComponent implements OnInit {
length=0;
breadth=0;
area=0;
  constructor() { }

  ngOnInit(): void {
  }
findArea(){
  this.area= this.length*this.breadth;
}
}
