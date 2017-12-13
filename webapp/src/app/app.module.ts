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
import {Contact} from './contact/contacts/contact';
import { ContactItemComponent } from './contact/contacts/contact-item/contact-item.component';
import {
  MatCardModule, MatDatepickerModule, MatExpansionModule, MatFormFieldModule,
  MatIconModule
} from '@angular/material';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { MapComponent } from './contact/contacts/map/map.component';


@NgModule({
  declarations: [
    AppComponent,
    ContactsComponent,
    AddContactComponent,
    ContactItemComponent,
    MapComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    MatExpansionModule,
    MatIconModule,
    MatFormFieldModule,
    MatCardModule
  ],
  providers: [ContactService, ContactHttpService, Contact],
  bootstrap: [AppComponent]
})
export class AppModule {}

