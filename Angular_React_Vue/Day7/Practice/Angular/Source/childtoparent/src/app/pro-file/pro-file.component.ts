import { Component, OnInit,Output,EventEmitter } from '@angular/core';


@Component({
  selector: 'app-pro-file',
  templateUrl: './pro-file.component.html',
  styleUrls: ['./pro-file.component.css']
})
export class ProFileComponent implements OnInit {
  myname=" "
  @Output() event1= new EventEmitter<string>();
  display(){
    this.event1.emit(this.myname);
  }
  constructor() { }

  ngOnInit(): void {
  }

}
