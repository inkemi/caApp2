using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Services;
using ContactWebApi.Models;

namespace ContactWebApi.Controllers
{
    [Route("api/contacts")]
    public class ContactsController : Controller
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var contacts = _contactService.FindContacts();
            return new JsonResult(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _contactService.FindContactById(id);
            return new JsonResult(contact);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Contact contact)
        {
            var contactResult = _contactService.CreateContact(contact);
            return new JsonResult(contactResult);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Contact contact)
        {
            var contactUpdate = _contactService.UpdateContact(contact);
            return new JsonResult(contactUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool result = _contactService.DeleteContact(id);

            if (result)
            {
                return new JsonResult("delete onnistui");
            }
            else
            {
                return new JsonResult("Delete epäonnistui");
            }
        }
    }


}
