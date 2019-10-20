using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using ContactCross.Core.Models;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace ContactCross.Core.ViewModels
{
    public class ContactListViewModel:MvxViewModel
    {
        //Properties
        private readonly IMvxNavigationService _navigationService;
        public ObservableCollection<Contact> Contacts { get; set; }

        //Const
        public ContactListViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact
            {
                Name = "Mustafa",
                Surname = "Hiçyılmaz"
            });
        }

        //MvvmCross Methods
        public override Task Initialize() => base.Initialize();

        //Commands
        public IMvxCommand NewPageCommand => new MvxCommand(NewPageAsync);

        private async void NewPageAsync()
        {
            await _navigationService.Navigate<AddContactViewModel,ObservableCollection<Contact>>(Contacts);
        }
    }
}
