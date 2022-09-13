import { Component, OnInit, Inject } from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog';
import { FormControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import{SingupService} from '../singup.service'
import { LoginService } from '../login.service';
import { Router } from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
phoneNumber= new FormControl('');
show:boolean=true;
user:any;
  token: string='';
  constructor(
    @Inject(MAT_DIALOG_DATA) public anyVariable:any, 
    private service:SingupService,
    private fb:FormBuilder, 
    private services:LoginService,
    private router: Router,
    public dialogRef: MatDialogRef<LoginComponent>,
    ) { }

  ngOnInit(): void {   
  }

  loginForm=this.fb.group({
    phone:[''],
    password:['']
  });
  SingupFormGroup=this.fb.group({
    userName:['', Validators.required],
    phone:['',  [Validators.required, Validators.pattern("^[0-9]*$"), Validators.maxLength(10), Validators.minLength(10)]],
    password:['',  [Validators.required, Validators.minLength(6)]],
    age:[ [Validators.required, Validators.min(18)]],
    gender!:[ Validators.required],
    isActive:[true],
    isSubscribed:[false],
    roleID:[2]
  });

  sendUser() {
    if(this.SingupFormGroup.invalid){
      alert("INVALID FORM CREDENTIALS");
      return;
    }
    this.user=this.SingupFormGroup.value;
    console.log(this.SingupFormGroup.errors);
    console.log(this.SingupFormGroup.value.age);
    this.user.gender = parseInt(this.user.gender);
    this.user.isActive =JSON.parse( this.user.isActive);
    this.user.isSubscribed =JSON.parse( this.user.isSubscribed);
    this.user.roleID =parseInt( this.user.roleID);

          this.service.postUser(this.user).subscribe((a: any) => { this.user = a });
    
    this.dialogRef.close();
    this.router.navigate(['/loggedin']);

      }

    login(){
      this.user = this.loginForm.value;

    if (this.user.phone == "" || this.user.password == "") {

      alert("phone number or password cannot be empty");

    }

    else {

      this.services.loginuser(this.user).subscribe

        ((data: { token: string; }) => {

          this.token = data.token;
          localStorage.setItem('token', data.token);


          let jwtData = data.token.split('.')[1];

          let decodedJwtJsonData = window.atob(jwtData);

          let decodedJwtData = JSON.parse(decodedJwtJsonData);



          console.log(data.token);

          console.log(decodedJwtData.role);

          localStorage.setItem('token', data.token);

         

          if(decodedJwtData.role=="Admin"){

            this.router.navigate(['/admin']);

          }

          else{

            this.router.navigate(['/loggedin']);

          }



        }, (error: HttpErrorResponse) => {

          alert("Invalid User Credentials.");

          this.loginForm.reset();

        });

    };
      this.dialogRef.close();
    }

}
