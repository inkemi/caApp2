import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { ContactsComponent } from './contact/contacts/contacts.component';
import { AddContactComponent } from './contact/add-contact/add-contact.component';
import {FormsModule} from '@angular/forms';
import {ContactService} from './contact/contacts/services/contact.service';
import {ContactHttpService} from './contact/contacts/services/contact-http.service';
import {HttpClientModule} from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    ContactsComponent,
    AddContactComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [ContactService, ContactHttpService],
  bootstrap: [AppComponent]
})
export class AppModule { }
