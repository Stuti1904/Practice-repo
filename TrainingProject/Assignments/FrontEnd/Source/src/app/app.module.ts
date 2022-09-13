import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavigationComponent } from './navigation/navigation.component';
import { AdvertisementComponent } from './advertisement/advertisement.component';
import { ContentComponent } from './content/content.component';
import { FooterComponent } from './footer/footer.component';
import { LoginComponent } from './login/login.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatDialogModule } from '@angular/material/dialog';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { TrialComponent } from './trial/trial.component';
import { MissionMangalComponent } from './mission-mangal/mission-mangal.component';
import { HomeComponent } from './home/home.component';
import { ContentdetailComponent } from './contentdetail/contentdetail.component';
import { VideopageComponent } from './videopage/videopage.component';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { LoggedInComponent } from './logged-in/logged-in.component';
import { LoggedInNavComponent } from './logged-in-nav/logged-in-nav.component';
import { AdminResourceComponent } from './admin-resource/admin-resource.component';
import { AdminEpisodeComponent } from './admin-episode/admin-episode.component';
import { AdminContentComponent } from './admin-content/admin-content.component';
import { AdminUsersComponent } from './admin-users/admin-users.component';
import { AngularFireModule } from "@angular/fire/compat";
import { environment } from 'src/environments/environment';
import { AngularFirestoreModule } from '@angular/fire/compat/firestore';
import { UsersComponent } from './users/users.component';
import { ResourcesComponent } from './resources/resources.component';
import { ContentsComponent } from './contents/contents.component';
import { EpisodesComponent } from './episodes/episodes.component';
import { EditUsersComponent } from './edit-users/edit-users.component';
import { EditContentComponent } from './edit-content/edit-content.component';
import { LoginHomeComponent } from './login-home/login-home.component';
import { WatchListComponent } from './watch-list/watch-list.component';
import { SubscribeComponent } from './subscribe/subscribe.component';
import { CheckOutComponent } from './check-out/check-out.component';
import { ComponentDummyComponent } from './component-dummy/component-dummy.component';
@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    AdvertisementComponent,
    ContentComponent,
    FooterComponent,
    LoginComponent,
    TrialComponent,
    MissionMangalComponent,
    HomeComponent,
    ContentdetailComponent,
    VideopageComponent,
    AdminHomeComponent,
    LoggedInComponent,
    LoggedInNavComponent,
    AdminResourceComponent,
    AdminEpisodeComponent,
    AdminContentComponent,
    AdminUsersComponent,
    UsersComponent,
    ResourcesComponent,
    ContentsComponent,
    EpisodesComponent,
    EditUsersComponent,
    EditContentComponent,
    LoginHomeComponent,
    WatchListComponent,
    SubscribeComponent,
    CheckOutComponent,
    ComponentDummyComponent,
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatDialogModule,
    ReactiveFormsModule,
    HttpClientModule,
    AngularFirestoreModule,
    AngularFireModule.initializeApp(environment.firebaseConfig)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
