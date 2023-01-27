using Contact.Api.Infrastructure;
using Contact.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Api.Services
{
    public class ContactService : IContactService
    {
        public ContactDto GetContactById(int id)
        {
            return new ContactDto()
            {
                FirstName = "Okan",
                LastName = "Demir",
                Id = id,
            };
        }
    }
}
