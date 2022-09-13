import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Validators } from '@angular/forms';
@Component({
  selector: 'app-fb-and-validation',
  templateUrl: './fb-and-validation.component.html',
  styleUrls: ['./fb-and-validation.component.css']
})
export class FbAndValidationComponent implements OnInit {
loginform: FormGroup;
  constructor(private fb: FormBuilder) { 
    this.loginform= this.fb.group(
      {
        email:['', Validators.required],
        password:['', Validators.required],
        login:[''],​
      }
    )
  }
status(){
  console.log(this.loginform.status);
}
  ngOnInit(): void {
  }

}
