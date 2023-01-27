using Contact.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Api.Infrastructure
{
    public interface IContactService
    {
        public ContactDto GetContactById(int id);
    }
}
