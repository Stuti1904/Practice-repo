import { Component, OnInit } from '@angular/core';
import { adminUser } from 'Models/adminUser';
import { AdminUserServiceService } from '../admin-user-service.service';
import { content } from 'Models/content';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
content !:content;
deleted:any;
  userList: Array<any>=[];
  roleList:Array<any>=[];
  Admin:Array<any>=[];
  show=false;
  user:any;
  token: string='';
    d:any= new Date(Date.now());
    now:any = this.d.toISOString();
   addAdmin=this.fb.group({
    userName:[''],
    age:[],
    gender:[],
    isActive:[true],
    isSubscribed:[false],
    roleID:[1],
    createddate:[this.now]
  });
  constructor(private service:AdminUserServiceService, private fb:FormBuilder) { }
  ngOnInit(): void {
    this.service.getroles().subscribe((role:Array<any>)=>{
      this.roleList = role;
  })
  console.log(this.roleList)
    this.service.getadmin().subscribe((admin: Array<adminUser>)=>{
      this.Admin=admin;
    })

    this.service.getAllUsers().subscribe((users: Array<any>)=>{
      this.userList = users;
    })
   
   
  }
  delete(id:number){
    this.service.delete(id).subscribe((a:any)=>{
      this.ngOnInit();
    }); 
  }
 

}
