import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { FormBuilder } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormArrayComponent } from './form-array/form-array.component';
import { FbAndValidationComponent } from './fb-and-validation/fb-and-validation.component';

@NgModule({
  declarations: [
    AppComponent,
    FormArrayComponent,
    FbAndValidationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
