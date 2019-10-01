using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sekreter.Core.Models
{
    public class PhoneContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public IList Numbers { get; set; }
        public IList Emails { get; set; }

        public PhoneContact()
        {
            Numbers = new List<string>();
            Emails = new List<string>();
        }
    }
}
