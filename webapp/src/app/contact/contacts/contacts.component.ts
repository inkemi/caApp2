import { Component, OnInit } from '@angular/core';
import {Contact} from './contact';
import {ContactService} from './services/contact.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html',
  styleUrls: ['./contacts.component.scss']
})
export class ContactsComponent implements OnInit {
  id = '';
  firstName = '';
  lastName = '';
  phone = '';
  street = '';
  city = '';
  contact: [''];
  btnText = 'Edit a Contact';
  editfirstName = '';
  editlastName = '';
  editphone = '';
  editstreet = '';
  editcity = '';

  public contacts: Contact[];

  constructor(private contactService: ContactService) {
    this.contacts = null;
  }

  ngOnInit() {
    // this.contactCount = this.contact.contacts.length;
    // this.contacts = this.contactService.getContacts();
    this.updateContacts();
  }

  public updateContacts() {
    this.contactService.findContact().subscribe(result => {
      console.log(result);
      this.contacts = result;
    });
  }

  onContactSelect(contact: any) {
    this.contact = this.contact;
    this.id = contact.id;
    this.firstName = contact.firstName;
    this.lastName = contact.lastName;
    this.phone = contact.phone;
    this.street = contact.street;
    this.city = contact.city;
   // this.router.navigate(['/contact-item', contact.id]);
  }
  editContact(contact: any) {
    this.editfirstName = this.firstName;
    this.editlastName = this.lastName;
    this.editphone = this.phone;
    this.editstreet = this.street;
    this.editcity = this.city;
    console.log(this.id, this.editfirstName, this.editlastName, this.editphone, this.editstreet, this.editcity);
  }
  //findContact(){
    // console.log(this.contact);
 // }


  public onContactEdit(contact: Contact) {
    console.log(contact);
    this.contactService.editContact2(contact).subscribe(() => {
      this.updateContacts();
    });
  }

}
