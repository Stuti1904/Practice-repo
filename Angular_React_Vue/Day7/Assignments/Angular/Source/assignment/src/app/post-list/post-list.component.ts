import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrls: ['./post-list.component.css'],
})
export class PostListComponent implements OnInit {
  @Output() dataEvent = new EventEmitter<any>();
  constructor() {}

  ngOnInit(): void {}

  arrPost: Array<Post> = [
    {
      postID: 1,
      postName: 'BTS',
      postDescription: 'FAV BTS PHOTO',
      postedDate: new Date().toString(),
      postedImage:
        'https://lh3.googleusercontent.com/8esyZH6UJgld6dy5lX_PBwBScmaYMjdBpY4DDHuFwAx1PUohyMAmoWD73jwdC6cEC7cMOvzihRndtXO0mOObccZgWAlhkHrrSQJAhl2RPUAuINEg=w960-rj-l80-nu-e365',
      isLiked: false,
    },
    {
      postID: 2,
      postName: 'ONE DIRECTION',
      postDescription: 'FAV ONE DIRECTION PHOTO',
      postedDate: new Date().toString(),
      postedImage:
        'http://hd.wallpaperswide.com/thumbs/one_direction_480x272-t2.jpg',
      isLiked: false,
    },
    {
      postID: 3,
      postName: 'NCT',
      postDescription: 'FAV NCT PHOTO',
      postedDate: new Date().toString(),
      postedImage:
        'https://images7.alphacoders.com/120/thumb-1920-1207556.jpg',
      isLiked: false,
    },
  ];

  arrLiked: Array<Post> = [];

  like(post: Post) {
    post.isLiked = true;
    this.arrLiked.push(post);
    console.log(this.arrLiked);
    this.dataEvent.emit(this.arrLiked);
  }
}

class Post {
  postID: number;
  postName: string;
  postDescription: string;
  postedDate: string;
  postedImage: string;
  isLiked: boolean;

  constructor(
    id: number,
    name: string,
    desc: string,
    date: string,
    image: string,
    isLiked: boolean
  ) {
    this.postID = id;
    this.postName = name;
    (this.postDescription = desc), (this.postedDate = date);
    this.postedImage = image;
    this.isLiked = isLiked;
  }
}
