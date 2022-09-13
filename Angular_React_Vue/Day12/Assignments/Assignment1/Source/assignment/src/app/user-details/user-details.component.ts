import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css'],
})
export class UserDetailsComponent implements OnInit {
  userDetails: Array<any> = [
    {
      userID: 1,
      userName: 'Roy',
      Gender: 'Male',
      designation: 'Developer',
      PanNumber: '335454',
    },
    {
      userID: 2,
      userName: 'Rohit',
      Gender: 'Male',
      designation: 'Junior Developer',
      PanNumber: 'abcd',
    },
  ];
  userID = '';
  arrdetail: Array<any> = [];
  constructor(private activeroute: ActivatedRoute) {}

  ngOnInit() {
    this.activeroute.params.subscribe((p) => {
      this.userID = p['id'];
      this.arrdetail = this.userDetails.filter((p) => p.userID == this.userID);
    });
  }
}
