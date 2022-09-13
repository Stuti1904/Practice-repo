import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { UserListComponent } from './user-list/user-list.component';
const routes: Routes = [{ path: 'userList/:id', component: UserListComponent }];
@NgModule({
  imports: [BrowserModule, FormsModule, RouterModule.forRoot(routes)],
  declarations: [AppComponent,  UserListComponent],
  exports: [RouterModule],
  bootstrap: [AppComponent],
})
export class AppModule {}
