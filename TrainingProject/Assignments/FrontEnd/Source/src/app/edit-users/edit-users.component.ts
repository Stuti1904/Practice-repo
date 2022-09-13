import { Component, OnInit } from '@angular/core';
import { AdminUserServiceService } from '../admin-user-service.service';
import { FormBuilder } from '@angular/forms';
import { adminUser } from 'Models/adminUser';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-users',
  templateUrl: './edit-users.component.html',
  styleUrls: ['./edit-users.component.css']
})
export class EditUsersComponent implements OnInit {

  adminList:Array<any>=[];
  selectedUserId:number=0;
  d:any= new Date(Date.now());
    now:any = this.d.toISOString();
   addAdmin=this.fb.group({
    userName:[''],
    age:[],
    gender:[],
    isActive:[true],
    isSubscribed:[false],
    roleID:[1],
    modifiedDate:[this.now]
  });
  user:any;
  constructor(private service:AdminUserServiceService, private fb:FormBuilder, private activatedRoute:ActivatedRoute) { }

  ngOnInit(): void {
    this.service.getadmin().subscribe((admin: Array<adminUser>)=>{
      this.adminList = admin;
      this.adminList.forEach(element => {
        console.log(element);
        if(element.userId==this.selectedUserId){
          console.log(element);
         
          this.addAdmin.controls['userName'].setValue(element.userName);
          this.addAdmin.controls['age'].setValue(element.age);
          this.addAdmin.controls['gender'].setValue(element.gender);
        }
      });
    })

    this.activatedRoute.params.subscribe((params:any)=>{
      this.selectedUserId=params["id"];
console.log(this.selectedUserId);
    })
    
  }
  update(id:number){
    this.user=this.addAdmin.value;
    this.service.put(this.user, id).subscribe((admin: adminUser)=>{
      this.user=admin;
      
    })
    this.addAdmin.reset();
    console.log(this.addAdmin.value);
  }

}
