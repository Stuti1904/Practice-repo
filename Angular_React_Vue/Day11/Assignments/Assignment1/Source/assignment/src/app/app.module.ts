import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AboutMeComponent } from './about-me/about-me.component';
import { EducationDetailsComponent } from './education-details/education-details.component';
import { ProjectsDoneComponent } from './projects-done/projects-done.component';
import { SkillsLearntComponent } from './skills-learnt/skills-learnt.component';
import { MyHobbiesComponent } from './my-hobbies/my-hobbies.component';

@NgModule({
  declarations: [
    AppComponent,
    AboutMeComponent,
    EducationDetailsComponent,
    ProjectsDoneComponent,
    SkillsLearntComponent,
    MyHobbiesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
