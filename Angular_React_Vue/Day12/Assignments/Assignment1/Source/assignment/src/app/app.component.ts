import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'user';
  userList: Array<any> = [
    {
      userID: 1,
      userName: 'Roy',
    },
    {
      userID: 2,
      userName: 'Rohit',
    },
  ];
  constructor(private router: ActivatedRoute, private route: Router) {}

  ngOnInit() {}
  details(id: any) {
    this.route.navigate(['userList', id], { relativeTo: this.router });
  }
}
