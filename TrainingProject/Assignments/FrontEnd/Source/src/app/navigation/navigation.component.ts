import { Component, OnInit } from '@angular/core';
import {LoginComponent} from '../login/login.component'
import { MatDialogRef, MatDialog } from '@angular/material/dialog'
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { ContentService } from '../content.service';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent implements OnInit {


  constructor( private matDialog: MatDialog, private fb:FormBuilder, private router:Router, private service:ContentService) { }
searchForm=this.fb.group({
  searchInput: ['']
});
 temp:any;
  ngOnInit(): void {

  }
  openModal() {
    this.matDialog.open(LoginComponent, {
      "autoFocus": false,
    });
  }
  search(){
    debugger
    this.temp= this.searchForm.value.searchInput;
    var toroute=this.service.getone(this.temp);
    if(toroute==null){
      this.router.navigate(["home"]);
    }
    else{
this.router.navigate(["contentdetail/"+ this.temp]);
    }
  }

  isLoggedIn() {

    if (localStorage.getItem('token') == null) {

      return false;

    }

    else {

      return true;

    }

  }
  logout() {

    localStorage.removeItem('token');

  }
}
