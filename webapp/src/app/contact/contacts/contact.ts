export class Contact {
  public id: number;
  public firstName: string;
  public lastName: string;
  public phone: string;
  public street: string;
  public city: string;

  constructor() {
    this.id = 0;
    this.firstName = '';
    this.lastName = '';
    this.phone = '';
    this.street = '';
    this.city = '';
  }
}
