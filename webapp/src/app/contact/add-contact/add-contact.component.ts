import { Component, OnInit } from '@angular/core';
import {Contact} from '../contacts/contact';
import {ContactService} from '../contacts/services/contact.service';

@Component({
  selector: 'app-add-contact',
  templateUrl: './add-contact.component.html',
  styleUrls: ['./add-contact.component.scss']
})
export class AddContactComponent implements OnInit {

  btnText = 'Add a Contact';

  public contact: Contact;

  constructor(private contactService: ContactService) {
    this.contact = new Contact();
  }

  ngOnInit() {

  }

  addContact() {
    console.log(this.contact);
    this.contactService.addContact(this.contact);
    this.contact = new Contact();
  }

}
