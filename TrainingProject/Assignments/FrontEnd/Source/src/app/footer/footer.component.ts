import { Component, OnInit } from '@angular/core';
import{ FormControl} from '@angular/forms'
@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  phoneNumber= new FormControl('');
  constructor() { }

  ngOnInit(): void {
  }

}
