import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContentdetailComponent } from './contentdetail/contentdetail.component';
import { HomeComponent } from './home/home.component';
import {LoginComponent} from './login/login.component'
import { MissionMangalComponent } from './mission-mangal/mission-mangal.component';
import { VideopageComponent } from './videopage/videopage.component';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { LoggedInComponent } from './logged-in/logged-in.component';
import { AdminResourceComponent } from './admin-resource/admin-resource.component';
import { UsersComponent } from './users/users.component';
import { ResourcesComponent } from './resources/resources.component';
import { ContentsComponent } from './contents/contents.component';
import { EditUsersComponent } from './edit-users/edit-users.component';
import { EditContentComponent } from './edit-content/edit-content.component';
import { LoginHomeComponent } from './login-home/login-home.component';
import { WatchListComponent } from './watch-list/watch-list.component';
import { SubscribeComponent } from './subscribe/subscribe.component';
import { CheckOutComponent } from './check-out/check-out.component';

const routes: Routes = [
  {path: '', redirectTo: '/home', pathMatch:'full'},
  {path: 'home', component: HomeComponent},     
  {path: 'login', component: LoginComponent},
  {path:'contentdetail/:title', component:ContentdetailComponent},
  {path: 'videopage/:title', component:VideopageComponent},
  {path:'admin', component:AdminHomeComponent,
children:[{
  path: 'resource',component:ResourcesComponent},
  {path: 'users', component:UsersComponent},
  {path:'content', component:ContentsComponent},
  {path: 'users/edituser/:id', component:EditUsersComponent},
  {path:'content/editcontent/:id', component:EditContentComponent}
]},
  {path: 'loggedin', component:LoggedInComponent},
  {path:'watchlist', component:WatchListComponent},
  {path:'subscribe', component:SubscribeComponent},
  {path:'checkout', component:CheckOutComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
