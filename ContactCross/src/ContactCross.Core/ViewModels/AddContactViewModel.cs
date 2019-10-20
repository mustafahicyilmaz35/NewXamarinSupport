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
    public class AddContactViewModel : MvxViewModel, IMvxViewModel<ObservableCollection<Contact>>
    {
        //Properties
        private readonly IMvxNavigationService _navigationService;
        private ObservableCollection<Contact> _contacts;
        private string _name;
        private string _surname;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Surname
        {
            get => _surname;
            set => SetProperty(ref _surname, value);
        }


        //Constructor
        public AddContactViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        //MvvmCross Methods
        public override Task Initialize() => base.Initialize();

        public void Prepare(ObservableCollection<Contact> parameter)
        {
            _contacts = parameter;
        }

        //Commands
        public MvxCommand AddCommand => new MvxCommand(AddAction);
        public MvxCommand BackCommand => new MvxCommand(BackAction);

        private void BackAction()
        {
            _navigationService.Close(this);
        }


        private void AddAction()
        {
            _contacts.Add(new Contact
            {
                Name = Name,
                Surname = Surname
            });
            _navigationService.Close(this);
        }

    }
}
