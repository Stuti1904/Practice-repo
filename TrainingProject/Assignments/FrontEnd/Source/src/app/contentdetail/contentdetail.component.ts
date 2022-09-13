import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { content } from 'Models/content';
import { generalInfo } from 'Models/generalInfo';
import { CrudService } from '../crud.service';
import { DetailsService } from '../details.service';
import { LoggedInNavComponent } from '../logged-in-nav/logged-in-nav.component'
import { AdminUserServiceService } from '../admin-user-service.service';
import { PlaylistService } from '../playlist.service';
import { ContentService } from '../content.service';
@Component({
  selector: 'app-contentdetail',
  templateUrl: './contentdetail.component.html',
  styleUrls: ['./contentdetail.component.css']
})
export class ContentdetailComponent implements OnInit {
  token = localStorage.getItem('token') || ' ';
  show = 0;
  userId: any;
  tempId: any;
  viewtemp=0;
  Info: Array<any> = [];
  tempobject = {
    userId: '',
    contentId: ''
  };
  selectedContentTitle: any;
  Content: Array<content> = [];

  constructor(private service: DetailsService, private activatedRoute: ActivatedRoute, private services: CrudService, private userService: AdminUserServiceService,
    private playlistservice:PlaylistService, private router:Router, private contentService: ContentService) { }

  ngOnInit(): void {
    if (this.token == null) {
      this.show = 1
    }
    this.service.getdetails().subscribe((info: Array<any>) => {
      this.Info = info;
    })
    this.activatedRoute.params.subscribe((p:any) => { this.selectedContentTitle = p["title"] })
    this.services.getContent().subscribe((content: Array<content>) => {

      this.Content = content;

    })
  }
  getWatchlist(name: string) {
   
    this.Content.forEach(element => {
      if (element.title ==name) {
        this.tempId = element.contentId;
      }
    });
    let payload = this.token.split('.')[1];

    let decodedPayload = window.atob(payload);

    let parsedPayload = JSON.parse(decodedPayload);
    let phoneNumber = parsedPayload.unique_name;
    this.userService.getbyphone(phoneNumber).subscribe((a: any) => {
      this.userId = a.userId;
      this.tempobject.userId = this.userId;
      this.tempobject.contentId = this.tempId;
      this.playlistservice.post(this.tempobject).subscribe((a: any) => { this.tempobject = a });
      this.router.navigate(["watchlist"])
    })

  
    

  }

  updateview(id:any){
    this.contentService.view(id).subscribe((a:any) => {
this.viewtemp=a;
    })
  }
}





