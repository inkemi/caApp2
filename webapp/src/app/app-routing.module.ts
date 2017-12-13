import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {AddContactComponent} from './contact/add-contact/add-contact.component';
import {ContactsComponent} from './contact/contacts/contacts.component';

const routes: Routes = [
  {
    path: 'add-contact',
    component: AddContactComponent
  },
  {
    path: 'contacts',
    component: ContactsComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
