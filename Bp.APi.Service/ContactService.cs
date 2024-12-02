using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BP.Api.Data.Models;
using BP.Api.Models;

namespace Bp.APi.Service
{
    public class ContactService : IContactService
    {
        private readonly IMapper mapper;
        private readonly IHttpClientFactory httpClientFactory;

        public ContactService(IMapper Mapper, IHttpClientFactory httpClientFactory)
        {
            mapper = Mapper;
            this.httpClientFactory = httpClientFactory;
        }
        public ContactDVO GetContactById(int id)
        {
            // veri tabanından kaydın getirilmesi.

            Contact dbContact = getDummyContact();

            var client = httpClientFactory.CreateClient("adatepeapi");

            //HttpClient client = new HttpClient();

            //client.BaseAddress = new Uri("adatepe.com");

            //client.DefaultRequestHeaders.Add("Authorization", "Bearer 234232423");

            //string get = await client.getstringasync("/api/getpayment");

            //client.dispose();




            ContactDVO resultContact = new ContactDVO();

            mapper.Map(dbContact, resultContact);


            return resultContact;


            //return new ContactDVO()
            //{
            //   Id = dbContact.Id,
            //  FullName = $"{dbContact.FirstName} {dbContact.LastName}"
            //};
        }

        private Contact getDummyContact()
        {
            return new Contact()
            {
                Id = 1,
                FirstName = "Adem",
                LastName = "ADATEPE"
            };
        }
    }
}
