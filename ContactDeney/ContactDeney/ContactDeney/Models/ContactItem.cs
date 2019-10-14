using System;
using System.Collections.Generic;
using System.Text;

namespace ContactDeney.Models
{
    public class ContactItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
