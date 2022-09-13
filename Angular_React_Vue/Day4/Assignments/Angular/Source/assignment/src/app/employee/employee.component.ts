import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  
  constructor() { }
  employees:any=[]
  employee= {
    id: " "  ,
     name: " ",
    address: " ",
    gender: " ",
    date: " ",
    hobbies: " ",
  };
  ngOnInit(): void {
  }
check(){
var tempobj={empid:this.employee.id, empname: this.employee.name, empgender: this.employee.gender, empdate: this.employee.date, empaddress:this.employee.address, emphobby:this.employee.hobbies}
this.employees.push(tempobj);
console.log(this.employees);
this.employee.id=" ";
this.employee.name=" ";
this.employee.address=" ";
this.employee.date=" ";
this.employee.gender=" ";
this.employee.hobbies=" ";
}
}
