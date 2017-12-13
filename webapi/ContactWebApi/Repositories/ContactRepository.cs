using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private ContactContext _dbContext;

        public ContactRepository(ContactContext context)
        {
            _dbContext = context;
        }

        public List<Contact> GetAll()
        {
            return _dbContext.Contacts.ToList();
        }

        public Contact GetById(int id)
        {
            return _dbContext.Contacts.Where(c => c.Id == id).FirstOrDefault();
        }

        public Contact Create(Contact contact)
        {

            /*
            var newContact = new Contact
            {
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone,
                Street = contact.Street,
                City = contact.City
            };
            */


            _dbContext.Contacts.Add(contact);
            _dbContext.SaveChanges();

            return contact;
        }

        public Contact Update(Contact contact)
        {

            var updatedContact = _dbContext.Contacts.Where(c => c.Id == contact.Id).FirstOrDefault();

            if (updatedContact == null)
            {
                return null;
            }

            updatedContact.FirstName = contact.FirstName;
            updatedContact.LastName = contact.LastName;
            updatedContact.Phone = contact.Phone;
            updatedContact.Street = contact.Street;
            updatedContact.City = contact.City;

            _dbContext.Contacts.Update(updatedContact);
            _dbContext.SaveChanges();

            return updatedContact;
        }

        public bool Delete(int id)
        {
            var deleteContact = _dbContext.Contacts.Where(c => c.Id == id).FirstOrDefault();

            if (deleteContact != null)
            {
                _dbContext.Contacts.Remove(deleteContact);
                _dbContext.SaveChanges();
                return true;
            }

            return false;
        }

    }
}
