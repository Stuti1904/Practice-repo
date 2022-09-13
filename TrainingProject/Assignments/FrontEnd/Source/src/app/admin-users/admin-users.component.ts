import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SingupService } from '../singup.service';

@Component({
  selector: 'app-admin-users',
  templateUrl: './admin-users.component.html',
  styleUrls: ['./admin-users.component.css']
})
export class AdminUsersComponent implements OnInit {
  user:any;
  token: string='';
  constructor(
    @Inject(MAT_DIALOG_DATA) public anyVariable:any, 
    private service:SingupService,
    private fb:FormBuilder, 
    private router: Router,
    public dialogRef: MatDialogRef<AdminUsersComponent>,
    ) { }
    d:any= new Date(Date.now());
    now:any = this.d.toISOString();
  submitted=false;
  ngOnInit(): void {   
  }

   addAdmin=this.fb.group({
    userName:['', Validators.required],
    phone:['',  [Validators.required, Validators.pattern("^[0-9]*$"), Validators.maxLength(10), Validators.minLength(10)]],
    password:['',  [Validators.required, Validators.minLength(6)]],
    age:[ [Validators.required, Validators.min(18)]],
    gender!:[ Validators.required],
    isActive:[true],
    isSubscribed:[false],
    roleID:[1],
    createddate:[this.now]
  });

  sendUser() {
    this.submitted=true;
    if(this.addAdmin.invalid){
      alert("INVALID FORM CREDENTIALS");
      return;
    }
    this.user=this.addAdmin.value;
    this.user.gender = parseInt(this.user.gender);
    this.user.isActive =JSON.parse( this.user.isActive);
    this.user.isSubscribed =JSON.parse( this.user.isSubscribed);
    this.user.roleID =parseInt( this.user.roleID);

          this.service.postUser(this.user).subscribe((a: any) => { this.user = a });
    
    this.dialogRef.close();
      }

       
    }



