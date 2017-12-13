import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs/Observable';
import {Contact} from '../contact';
import 'rxjs/add/operator/map';
import {environment} from '../../../../environments/environment';

@Injectable()
export class ContactHttpService {

  private url: string;

  constructor(private http: HttpClient) {
    this.url = environment.endpointUrl + '/contacts';
  }

  get(): Observable<Contact[]> {
    return this.http.get(this.url).map((response) => {
      return response as Contact[];
    });
  }

  newUser(contact: Contact): Observable<Contact> {
    return this.http.post<Contact>(this.url, contact);
  }

  updateUser(contact: Contact): Observable<Contact> {
    return this.http.put<Contact>( this.url + '/' + contact.id, contact).map((result) => {
      return result as Contact;
    });
  }

  deleteUser(contact: Contact): Observable<Contact> {
    return this.http.delete<Contact>( this.url + '/' + contact.id).map((result) => {
      return result as Contact;
    });
  }
}
