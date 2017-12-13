import {Injectable} from '@angular/core';
import {ContactsComponent} from '../contacts.component';
import {ContactHttpService} from './contact-http.service';
import {Observable} from 'rxjs/Observable';
import {Contact} from '../contact';
import {Editcontact} from '../editcontact';
import * as _ from 'lodash';


@Injectable()
export class ContactService {

  private contacts: Contact[];

  constructor(private contactHttpService: ContactHttpService) {
    this.contacts = [];
  }

  findContact(): Observable<Contact[]> {
    return this.contactHttpService.get().map(result => {
      this.contacts = result;
      return result;
    });
  }

  addContact(contact: Contact) {

    this.contactHttpService.newUser(contact).subscribe(result => {
      console.log(result);
    });

    /*
    if (this.contacts.length > 0) {
      console.log(contact);
      this.contactHttpService.newUser(contact).subscribe(result => {
        console.log(result);
      });
    } else {
      // contact.id = 1;
    }
    */
  }

  editContact2(contact) {
    console.log(contact);
    return this.contactHttpService.updateUser(contact);
  }

  deleteContact(contact) {
    console.log(contact);
    _.remove(this.contacts, function (c) {
      return c.id === contact.id;
    });
    this.contactHttpService.deleteUser(contact).subscribe();
  }
}
