using System;
using Bp.APi.Service;
using BP.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly IContactService contactService;

        public ContactController(IConfiguration Configuration, IContactService ContactService)
        {
            configuration = Configuration;
            contactService = ContactService;
        }



        [HttpGet]
        public String Get()
        {
            return configuration["ReadMe"].ToString();
        }


        [ResponseCache(Duration = 10)] // 10 saniye cache te tutulacak
        [HttpGet("{id}")]
        public ContactDVO GetContactById(int id)
        {
            return contactService.GetContactById(id);
        }

        [HttpPost]
        public ContactDVO CreateContact(ContactDVO contact)
        {

            // create contact on db
            return contact;
        }
    }
}
