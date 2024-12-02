using System;
using System.Collections.Generic;
using System.Text;
using BP.Api.Models;

namespace Bp.APi.Service
{
    public interface IContactService
    {

        public ContactDVO GetContactById(int id);

    }
}
