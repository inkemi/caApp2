using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Repositories
{
    public interface IContactRepository
    {
        List<Contact> GetAll();
        Contact GetById(int id);

        Contact Create(Contact contact);

        Contact Update(Contact contact);

        bool Delete(int id);
    }
}
