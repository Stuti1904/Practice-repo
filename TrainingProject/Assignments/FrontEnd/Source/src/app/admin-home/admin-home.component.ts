import { Component, OnInit } from '@angular/core';
import { AdminResourceComponent } from '../admin-resource/admin-resource.component';
import { MatDialog } from '@angular/material/dialog';
import { AdminContentComponent } from '../admin-content/admin-content.component';
import {adminUser} from 'Models/adminUser'
import { AdminUserServiceService } from '../admin-user-service.service';
import { AdminEpisodeComponent } from '../admin-episode/admin-episode.component';
import { AdminUsersComponent } from '../admin-users/admin-users.component';
import { Router, ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-admin-home',
  templateUrl: './admin-home.component.html',
  styleUrls: ['./admin-home.component.css']
})
export class AdminHomeComponent implements OnInit {

  admin: Array<adminUser>=[];
  Admin:Array<adminUser>=[];
  constructor(private matDialog: MatDialog, private service:AdminUserServiceService,
    private route:ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
   
  }
  showuser(){
    this.router.navigate(['users'], {relativeTo: this.route})
  }
  showresources(){
    this.router.navigate(['resource'], {relativeTo: this.route})
  }
  showcontent(){
    this.router.navigate(['content'], {relativeTo: this.route})
  }
  openmodal() {
    this.matDialog.open(AdminResourceComponent, {
      "autoFocus": false,
    });
  }
  opencontent() {
    this.matDialog.open(AdminContentComponent, {
      "autoFocus": false,
    });
  }
  openEpisode() {
    this.matDialog.open(AdminEpisodeComponent, {
      "autoFocus": false,
    });
  }
  openuser() {
    this.matDialog.open(AdminUsersComponent, {
      "autoFocus": false,
    });
  }
}
