using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiTest.Models;

namespace WebApiTest.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
            {
                new Contact
                {
                    Id = 1,
                    Name = "Serge Klokov"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Asharia"
                }
            };
        }
    }
}