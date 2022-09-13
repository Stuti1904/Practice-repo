import { Component, OnInit } from '@angular/core';
import { AdminUserServiceService } from '../admin-user-service.service';
import { PlaylistService } from '../playlist.service';
import { ContentService } from '../content.service';

@Component({
  selector: 'app-watch-list',
  templateUrl: './watch-list.component.html',
  styleUrls: ['./watch-list.component.css']
})
export class WatchListComponent implements OnInit {
  userId: any;
  Content: Array<any> = [];
  playlist: Array<any> = [];
  tempdelete:any;
  constructor(private service: ContentService, private userService: AdminUserServiceService, private playlistService: PlaylistService) { }
  token = localStorage.getItem('token') || '';
  ngOnInit(): void {
    let payload = this.token.split('.')[1];

    let decodedPayload = window.atob(payload);

    let parsedPayload = JSON.parse(decodedPayload);
    let phoneNumber = parsedPayload.unique_name;
    this.service.getContent().subscribe((content: Array<any>) => {
      this.Content = content;
    })
    this.userService.getbyphone(phoneNumber).subscribe((a: any) => {
      this.userId = a.userId;
      this.playlistService.getByUserId(this.userId).subscribe((a: any) => { this.playlist = a });
    });
  }
  remove(id:number){
    this.playlistService.delete(id).subscribe((a:any)=>{ this.tempdelete=a;
      this.ngOnInit();
    });
 
  }
}
