using ContactWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Repositories;

namespace ContactWebApi.Services
{
    public class ContactService: IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public List<Contact> FindContacts()
        {
            return _contactRepository.GetAll();
        }

        public Contact FindContactById(int id)
        {
            return _contactRepository.GetById(id);
        }
        public Contact CreateContact(Contact contact)
        {
            return _contactRepository.Create(contact);
        }

        public Contact UpdateContact(Contact contact)
        {
            return _contactRepository.Update(contact);
        }

        public bool DeleteContact(int id)
        {
            return _contactRepository.Delete(id);
        }
    }
}
