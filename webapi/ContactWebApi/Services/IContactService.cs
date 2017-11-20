using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Services
{
    public interface IContactService
    {
        List<Contact> FindContacts();
        ContactService FindContactById();
    }
}
