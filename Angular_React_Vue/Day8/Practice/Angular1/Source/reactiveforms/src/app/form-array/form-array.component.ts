import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormArray, Form } from '@angular/forms';
@Component({
  selector: 'app-form-array',
  templateUrl: './form-array.component.html',
  styleUrls: ['./form-array.component.css']
})
export class FormArrayComponent implements OnInit {
arrayform: FormGroup;
  constructor() {
    this.arrayform= new FormGroup({
      hobbies: new FormArray([
        new FormControl()
      ])
    });
   }
   get gethobbies(){
     return this.arrayform.get('hobbies') as FormArray;
   }
   addhobbies(){
     this.gethobbies.push(new FormControl());
     console.log(this.arrayform.get('hobbies'));
   }
  ngOnInit(): void {
  }

}
