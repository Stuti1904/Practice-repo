import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {

  list:any=[];
id:any='';
name:any='';
address:any='';
  constructor(private std:StudentService) { }

  ngOnInit() {
    this.list= this.std.getList();
  }
add(){
var obj:any={Stdid:this.id, Stdname:this.name, Stdadd:this.address};
this.std.addStudent(obj);
}
remove(){
  this.std.deletestudent();
}

}
