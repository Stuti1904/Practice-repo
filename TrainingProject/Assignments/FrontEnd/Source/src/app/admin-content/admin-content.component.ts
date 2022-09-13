import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { ContentService } from '../content.service';

@Component({
  selector: 'app-admin-content',
  templateUrl: './admin-content.component.html',
  styleUrls: ['./admin-content.component.css']
})
export class AdminContentComponent implements OnInit {
newContent:any;
submitted=false;
date = new Date();
 now:any = this.date.toISOString();
  constructor(private fb:FormBuilder,
    private dialogRef: MatDialogRef<AdminContentComponent>,
    private service:ContentService) { }
AddContent=this.fb.group({
  title:['',Validators.required],
  language:['', Validators.required],
  releasedDate:['', Validators.required],
  description:['', Validators.required],
  contentType:[ , Validators.required],
  genre:[ , Validators.required],
  resourceId:[ ,Validators.required],
  cast:['', Validators.required],
  lengthInMinutes:[ ,Validators.required],
  createdBy:[ ,Validators.required],
  createdDate:[this.now],
  isActive:[true],
  isPaid:[ ,Validators.required]
})
  ngOnInit(): void {
  }
addContent(){
  this.submitted=true;
  if(this.AddContent.invalid){
    alert("INVALID FORM CREDENTIALS");
    return;
  }
  this.newContent=this.AddContent.value;
  this.newContent.contentType = parseInt(this.newContent.contentType);
  this.newContent.isActive =JSON.parse( this.newContent.isActive);
  this.newContent.resourceId = parseInt(this.newContent.resourceId);
  this.newContent.genre =parseInt( this.newContent.genre);
  this.newContent.lengthInMinutes =parseInt( this.newContent.lengthInMinutes);
  this.newContent.createdBy =parseInt( this.newContent.createdBy);
  this.newContent.isPaid =JSON.parse( this.newContent.isPaid);
this.service.postContent(this.newContent).subscribe((a:any)=>{ this.newContent = a});
  this.dialogRef.close();

}
 }


