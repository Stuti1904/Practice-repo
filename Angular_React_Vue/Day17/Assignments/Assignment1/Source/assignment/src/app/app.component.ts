import { Component, OnInit } from '@angular/core';
import { UserserviceService } from './userservice.service';
import { Post } from './Models/Posts';
import { FormBuilder, FormGroup } from "@angular/forms";
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'httpdemo';
  userprofile: FormGroup;
  post!: Post;
  posts: Array<Post> = [];
  usernew: any;
  constructor(private userservice: UserserviceService, private fb: FormBuilder) {
    this.userprofile = this.fb.group({
      id:[0],
      user_id: [0],
      title: [""],
      body: [""]
    })


  }
  ngOnInit(): void {
    this.userservice.getUsers().subscribe((p: Array<Post>) => {
      this.posts = p;
    })
  }
  postinfo() {
    console.log(this.userprofile.value);
    this.post = this.userprofile.value;
    this.userservice.postUser(this.post).subscribe((arg: Post) => {

      this.post = arg
      this.ngOnInit();
      console.log(this.post);

    });

  }
  editinfo(user:Post)
  {
    this.userprofile.setValue(user);
  }
  updateinfo()
  {
    this.post = this.userprofile.value;
    this.userservice.putUser(this.post,this.post.id).subscribe((arg: Post) => {
       this.post = arg
      console.log(this.post);

    });
    
  }
}