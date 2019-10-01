using System;
using System.Collections.Generic;
using System.Text;
using Sekreter.Core.Models;

namespace Sekreter.Core.Interfaces
{
    public interface IContactService
    {
        IEnumerable<PhoneContact> GetAllContact();
    }
}
