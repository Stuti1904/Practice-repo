import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, FormArray, Validators } from '@angular/forms';
@Component({
  selector: 'app-student-form',
  templateUrl: './student-form.component.html',
  styleUrls: ['./student-form.component.css']
})
export class StudentFormComponent implements OnInit {
   studentarray:any=[]
  profileForm:FormGroup;
  constructor(private fb: FormBuilder){
    this.profileForm= this.fb.group({
      Name: this.fb.group({
        FirstName:['', Validators.required],
        MiddelName: ['', Validators.required],
        LastName:['', Validators.required]
      }),
      Adress: this.fb.group({
        City:['', Validators.required],
        State:['', Validators.required],
        Country:['', Validators.required],
        Pin:['', Validators.required]
      }),
      FatherName: this.fb.group({
        FirstName:['', Validators.required],
        MiddelName:['', Validators.required],
        LastName:['', Validators.required],
        Email:['', Validators.required],
    EducationQualification:['', Validators.required],
   Proffesion:['', Validators.required],
   Designation:['', Validators.required],
   PhoneNumber:['', Validators.required]
      }),
      MotherName: this.fb.group({
        FirstName:['',Validators.required],
      MiddelName:['',Validators.required],
      LastName:['',Validators.required],
      Email:['',Validators.required],
    EducationQualification:['',Validators.required],
   Proffesion:['',Validators.required],
   Designation:['',Validators.required],
   PhoneNumber:['',Validators.required]
      }),
      EmergancyContactlist:['', Validators.required],
  Relation:['', Validators.required],
  Number:['', Validators.required],
  ReferenceDetails:['', Validators.required],
  ReferenceThrough:['', Validators.required],
  AddressWithTelNo:['', Validators.required]
    })
  }
    submitdata(){
     this.studentarray.push(this.profileForm.value);
     console.log(this.profileForm.status);
    }
  
     ngOnInit(): void {
  }
}
