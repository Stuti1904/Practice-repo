import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css'],
})
export class UserListComponent implements OnInit {
  id: any = '';
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
  arrdetail: Array<any> = [];
  constructor(private route: ActivatedRoute) {}
  ngOnInit() {
    this.route.paramMap.subscribe((p) => {
      this.id = p.get('id');
      this.arrdetail = this.userDetails.filter((e) => e.userID == this.id);
    });
  }
}
