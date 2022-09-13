import { Component, OnInit } from '@angular/core';
import { resources } from 'Models/resources';
import { ResourceService } from '../resource.service';
import { ContentService } from '../content.service';
import { adminCotent } from 'Models/adminContent';

@Component({
  selector: 'app-contents',
  templateUrl: './contents.component.html',
  styleUrls: ['./contents.component.css']
})
export class ContentsComponent implements OnInit {
deleted:any;
  content: Array<any>=[];
  Content:Array<any>=[];
  constructor(private service:ContentService) { }
  ngOnInit(): void {
    this.service.getContent().subscribe((content: Array<any>)=>{
      this.Content=content;
    })
  }
delete(id:number){
  debugger
  this.service.delete(id).subscribe((a:any)=>{ this.deleted=a});
  this.ngOnInit();
}
}
