import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {Contact} from '../contact';
import {Router} from '@angular/router';
import {ContactService} from '../services/contact.service';
import {Editcontact} from '../editcontact';

@Component({
  selector: 'app-contact-item',
  templateUrl: './contact-item.component.html',
  styleUrls: ['./contact-item.component.scss']
})
export class ContactItemComponent implements OnInit {
  btnEdit = 'Edit a Contact';
  btnEdit2 = 'Ok';
  btnDelete = 'Delete a Contact';
  edit: boolean;
  delete: boolean;
  map: boolean;

  public editcontact: Editcontact;
  @Input() contact: Contact;
  public updateContact: Contact;
  @Output() contactEdit;

  constructor(private router: Router, private contactService: ContactService) {
    this.updateContact = new Contact();
    this.contactEdit = new EventEmitter<Contact>();
  }

  ngOnInit() {
  }
  editContact() {
    this.edit = true;
    Object.assign(this.updateContact, this.contact);
  }
  editContact2() {
    this.edit = false;
    console.log('Updated contact:');
    console.log(this.updateContact);
    // this.contactService.editContact2(this.updateContact);
    this.contactEdit.emit(this.updateContact);
    }

  editContact3() {
    this.edit = false;
  }
  deleteContact() {
    this.delete = true;
    console.log(this.contact.id);
  }

  deleteContact2() {
    this.delete = false;
    this.contactService.deleteContact(this.contact);
  }

  deleteContact3() {
    this.delete = false;
    console.log(this.contact.id);
  }

  contactMap() {
    this.map = true;
    console.log('Map ', this.contact.id);
  }
  contactMap2() {
    this.map = false;
    console.log('Map ', this.contact.id);
  }
}
