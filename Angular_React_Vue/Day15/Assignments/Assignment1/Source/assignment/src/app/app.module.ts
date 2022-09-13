import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { StudentListComponent } from './student-list/student-list.component';
import { StudentService } from './student.service';
import { StudentComponent } from './student/student.component';

@NgModule({
  imports:      [ BrowserModule, FormsModule ],
  declarations: [ AppComponent, StudentListComponent, StudentComponent ],
  bootstrap:    [ AppComponent ],
  providers: [StudentService]
})
export class AppModule { }
