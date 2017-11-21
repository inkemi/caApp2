import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html',
  styleUrls: ['./contacts.component.scss']
})
export class ContactsComponent implements OnInit {

  contactCount: number;
  firstName: string;
  lastName: string;
  phone: string;
  street: string;
  city: string;
  btnText = 'Add a Contact';
  contacts = [];
  contact: string;


  constructor() { }

  ngOnInit() {
    this.contactCount = this.contacts.length;

  }
  addContact() {
    this.contact = this.firstName + ' ' + this.lastName + ' Phone: ' + this.phone + ' Address: ' + this.street + ' ' + this.city;
    this.contacts.push(this.contact);
    this.contact = '';
    this.contactCount = this.contacts.length;
  }

  findContact(){
    console.log(this.contact);
  }

}
