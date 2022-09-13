import { Component, OnInit } from '@angular/core';
import { generalInfo } from 'Models/generalInfo';
import { content } from 'Models/content';
import { DetailsService } from '../details.service';
import { ActivatedRoute } from '@angular/router';
import { CrudService } from '../crud.service';
import { ContentService } from '../content.service';
import { CommentService } from '../comment.service';
import { AdminUserServiceService } from '../admin-user-service.service';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-videopage',
  templateUrl: './videopage.component.html',
  styleUrls: ['./videopage.component.css']
})
export class VideopageComponent implements OnInit {
  Info: Array<generalInfo> = [];
  selectedContentTitle: any;
  selectedContentId:any;
  d:any= new Date(Date.now());
  now:any = this.d.toISOString();
  Content: Array<content> = [];
  Comments:Array<any>=[];
  Users:Array<any>=[];
  tempObj={
    userId:0, 
    contentId:0, 
    comment1:'' ,
    createdDate: this.now
  };
  token = localStorage.getItem('token') || '';
  constructor(private service: DetailsService, private activatedRoute: ActivatedRoute, private services: CrudService, 
    private contentService: ContentService,
    private commentService: CommentService,
    private userService:AdminUserServiceService,
    private fb:FormBuilder) { }
CommentFormGroup=this.fb.group({
  comment1:['', Validators.required]
})
  ngOnInit(): void {

    this.service.getdetails().subscribe((info: Array<generalInfo>) => {
      this.Info = info;
    })
    this.activatedRoute.params.subscribe((p: { [x: string]: any; }) => { this.selectedContentTitle = p["title"] })
    this.service.getdetails().subscribe((content: Array<generalInfo>) => {

      this.Info = content;

    })
    this.services.getContent().subscribe((a: any) => {
      this.Content = a;
    })
    this.userService.getAllUsers().subscribe((a:any)=>{ 
      this.Users=a;
    })
  }
  like(id: any) {
    this.contentService.like(id).subscribe((a: any) => {
      this.ngOnInit();
    })
  }
  dislike(id: any) {
    this.contentService.dislike(id).subscribe((a: any) => {
      this.ngOnInit();
    })
  }
  getcomments(id: any) {
this.commentService.getById(id).subscribe((a:any)=>{
this.Comments=a;
})
  }
  set(id:any){
    this.selectedContentId=id;
    console.log(this.selectedContentId);
  }
  postComment(){
    debugger
    this.tempObj.contentId=this.selectedContentId;
  
    console.log( "this fb"+ this.CommentFormGroup.value);
    let payload = this.token.split('.')[1];
    let decodedPayload = window.atob(payload);
    let parsedPayload = JSON.parse(decodedPayload);
    let phoneNumber = parsedPayload.unique_name;
    this.userService.getbyphone(phoneNumber).subscribe((a: any)=>{ 
      this.tempObj.userId=a.userId;
      this.tempObj.comment1=this.CommentFormGroup.value.comment1!;
      console.log(this.tempObj);
      this.commentService.postcomment(this.tempObj).subscribe((a: any)=>{
           console.log(a);
         });
    
    })
  }
}
