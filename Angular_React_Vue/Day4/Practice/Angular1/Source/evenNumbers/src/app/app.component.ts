import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
constructor() { }
list:Array<number>=[];
  generateArray()
  {
    for (let i = 0; i < 100; i++) {
      this.list[i] = i+1;
    }
  }
  ngOnInit(): void {
  }

}

