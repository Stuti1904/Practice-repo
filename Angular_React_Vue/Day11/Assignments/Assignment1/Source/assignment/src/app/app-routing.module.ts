import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutMeComponent } from './about-me/about-me.component';
import { EducationDetailsComponent } from './education-details/education-details.component';
import { MyHobbiesComponent } from './my-hobbies/my-hobbies.component';
import { ProjectsDoneComponent } from './projects-done/projects-done.component';
import { SkillsLearntComponent } from './skills-learnt/skills-learnt.component';

const routes: Routes = [
  { path: 'about-me', component:AboutMeComponent },
  { path: 'education-details', component: EducationDetailsComponent},
  { path: 'skills-learnt', component:SkillsLearntComponent },
  { path: 'my-hobbies', component:MyHobbiesComponent },
  { path: 'projects-done', component:ProjectsDoneComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
