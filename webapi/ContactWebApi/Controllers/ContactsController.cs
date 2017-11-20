using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Services;
using Microsoft.Azure.KeyVault.Models;

namespace ContactWebApi.Controllers
{
    [Route("api/contacs")]
    public class ContactsController: Controller
    {
        private readonly IContactService contactService;

        public ContactsController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var contacts = contactService;
        //    var contacts = new List<Contact>
        //    {
        //        new Contact(1, "Mikko", "Inkeröinen", "0505332216", "Kiertokatu 2 E 22" "Lappeenranta"),
        //        new Contact(2, "Jaska", "Jokunen", "040555566", "Jokukatu 2", "Jaskal")
         //   };

            return new JsonResult("assadfys");
        }
    }
}