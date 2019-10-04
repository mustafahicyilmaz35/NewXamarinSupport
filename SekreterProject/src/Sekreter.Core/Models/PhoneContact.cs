using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Bindings;
using MvvmCross.ViewModels;

namespace Sekreter.Core.Models
{
    public class PhoneContact:MvxViewModel
    {
        //public string FirstName { get; set; }
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                RaisePropertyChanged(()=>FirstName);
            }
        }
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
