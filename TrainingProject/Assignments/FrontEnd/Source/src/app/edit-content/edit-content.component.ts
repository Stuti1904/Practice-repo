import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ContentService } from '../content.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-content',
  templateUrl: './edit-content.component.html',
  styleUrls: ['./edit-content.component.css']
})
export class EditContentComponent implements OnInit {
contentList:Array<any>=[];
selectedContentId:number=0;
d:any= new Date(Date.now());
now:any=this.d.toISOString();
AddContent=this.fb.group({
  contentId:[0],
  title:[''],
  description:[''],
  language:[''],
  contentType:[],
  genre:[],
  cast:[],
  lengthInMinutes: [],
  resourceId:[],
  isActive:[true],
  createdBy:[2],
  modifiedBy:[2],
  modifiedDate:[this.now]
})
content:any;
  constructor(private fb:FormBuilder, private service:ContentService, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe((params:any)=>{ this.selectedContentId=params["id"];})
    console.log(this.selectedContentId);
    this.service.getContent().subscribe((content:Array<any>)=>{
      this.contentList=content;
      this.contentList.forEach(element=>{
        if(element.contentId==this.selectedContentId){
          this.AddContent.controls['description'].setValue(element.description);
          this.AddContent.controls['cast'].setValue(element.cast);
        //   this.AddContent.setValue(element);
        // }
        }
      });
    })
  
  }
  update(id:number){
    this.content=this.AddContent.value;
    this.service.put(this.content, id).subscribe((admin: any)=>{
      this.content=admin;
      
    })
    this.AddContent.reset();
    console.log(this.AddContent.value);
  }

}
