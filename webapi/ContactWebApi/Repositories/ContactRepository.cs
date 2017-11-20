using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private List<Contact> _contacts;

        public ContactRepository()
        {
            _contacts = new List<Contact>();
            Initialize();
        }

        public List<Contact> GetAll()
        {
           return _contacts;
        }

        public Contact GetById(int id)
        {
            return _contacts.FirstOrDefault(c => c.Id == id);
        }

        private void Initialize()
        {
                _contacts = new List<Contact>
                {
                    new Contact(1, "Mikko", "Inkeröinen", "0505332216", "Kiertokatu 2 E 22", "Lappeenranta"),
                    new Contact(2, "Jaska", "Jokunen", "040555566", "Jokukatu 2", "Jaskal")
               };
        }
    }
}
