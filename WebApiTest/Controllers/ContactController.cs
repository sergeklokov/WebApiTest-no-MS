using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;
using WebApiTest.Services;

namespace WebApiTest.Controllers
{
    public class ContactController : ApiController
    {
        //public string[] Get()
        //{
        //    return new string[]
        //    {
        //        "Hello",
        //        "World"
        //    };
        //}

        //public Contact[] Get()
        //{
        //    return new Contact[]
        //    {
        //        new Contact
        //        {
        //            Id = 1,
        //            Name = "Serge Klokov"
        //        },
        //        new Contact
        //        {
        //            Id = 2,
        //            Name = "Asharia"
        //        }
        //    };
        //}

        private ContactRepository contractRepository;

        public ContactController()
        {
            contractRepository = new ContactRepository(); // Test
        }

        public Contact[] Get()
        {
            return contractRepository.GetAllContacts();
        }
    }
}
