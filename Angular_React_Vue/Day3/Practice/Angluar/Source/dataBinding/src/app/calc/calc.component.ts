import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent implements OnInit {
first:number= 0;
second:number=0;
sum:number=0;
difference:number=0;
product:number=0;
quotient:number=0;
  constructor() { }

  ngOnInit(): void {
  }
addnumber(){
  this.sum= this.first+this.second;
  console.log(this.sum);
}
subtractnumber(){
  this.difference= this.first-this.second;
  console.log(this.difference);
}
multiplynumber(){
  this.product= this.first*this.second;
  console.log(this.product);
}
dividenumber(){
  if(this.second!=0){
  this.quotient= this.first/this.second;
  console.log(this.quotient);
}
else{
  console.log("DO NOT ENTER THE SECOND NUMBER AS ZERO")
}
}
}
