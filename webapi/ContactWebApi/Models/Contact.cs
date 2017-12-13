using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactWebApi.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contacts");
        }
    }

    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public Contact() {}

        public Contact(int id, string firstName, string lastName, string phone, string street, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Street = street;
            City = city;
        }
        
    }
}
