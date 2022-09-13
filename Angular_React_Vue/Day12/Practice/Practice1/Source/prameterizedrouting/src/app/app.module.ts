import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { Router, ActivatedRoute, RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { IndiaUsaComponent } from './india-usa/india-usa.component';
import { AtlanticPathComponent } from './atlantic-path/atlantic-path.component';
import { PacificPathComponent } from './pacific-path/pacific-path.component';
const routes: Routes = [
  { path: '', redirectTo: 'india-usa', pathMatch: 'full' },
  {
    path: 'india-usa',
    component: IndiaUsaComponent,
    children: [
      { path: 'atlantic', component: AtlanticPathComponent },
      { path: 'pacific', component: PacificPathComponent },
    ],
  },
];
@NgModule({
  imports: [BrowserModule, FormsModule, RouterModule.forRoot(routes)],
  declarations: [
    AppComponent,
    IndiaUsaComponent,
    PacificPathComponent,
    AtlanticPathComponent,
  ],
  bootstrap: [AppComponent],
  exports: [RouterModule],
})
export class AppModule {}
