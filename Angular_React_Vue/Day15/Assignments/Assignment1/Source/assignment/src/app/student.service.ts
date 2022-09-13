import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor() { }
  Studentarray=[{Stdid: 1, Stdname: "ABC", Stdadd: "XYZ"},
{Stdid: 2, Stdname: "DEF", Stdadd: "GHI"}]
getList(){
  return this.Studentarray;
}
addStudent(obj:any){
  this.Studentarray.push(obj);
}
deletestudent(){
  this.Studentarray.pop();
}
}
