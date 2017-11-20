using ContactWebApi.Model;
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

        public List<Contact> FindContacts()
        {
            throw new NotImplementedException();
        }

        public ContactService FindContactById()
        {
            throw new NotImplementedException();
        }
    }
}
