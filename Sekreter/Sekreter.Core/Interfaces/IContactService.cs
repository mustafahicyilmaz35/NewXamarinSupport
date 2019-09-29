using Sekreter.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sekreter.Core.Interfaces
{
    public interface IContactService
    {
        IEnumerable<PhoneContacts> GetAllContacts();
    }
}
