import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-india-usa',
  templateUrl: './india-usa.component.html',
  styleUrls: ['./india-usa.component.css']
})
export class IndiaUsaComponent implements OnInit {

  constructor(private router: ActivatedRoute,
    private route: Router){ }

  ngOnInit() {
  }
  viaAtlantic() {
    this.route.navigate(['atlantic'], { relativeTo: this.router});
 }

 viaPacific() {
   this.route.navigate(['pacific'], { relativeTo: this.router});
 }

}