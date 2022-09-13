import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeadeComponent } from './heade/heade.component';
import { SectionHomeComponent } from './section-home/section-home.component';
import { SectionAboutComponent } from './section-about/section-about.component';
import { FooTerComponent } from './foo-ter/foo-ter.component';

@NgModule({
  declarations: [
    AppComponent,
    HeadeComponent,
    SectionHomeComponent,
    SectionAboutComponent,
    FooTerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
