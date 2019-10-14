using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using ContactDeney.Annotations;
using ContactDeney.Models;
using Xamarin.Forms;

namespace ContactDeney.ViewModels
{
    class AddContactViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private ObservableCollection<ContactItem> _contactItems;

        public ICommand AddCommand { get; private set; }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {

            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }


        public AddContactViewModel(ObservableCollection<ContactItem> contactItems)
        {
            _contactItems = contactItems;
            AddCommand = new Command(AddAction);
        }

        private void AddAction()
        {
            _contactItems.Add(new ContactItem
            {
                FirstName = FirstName,
                LastName = LastName
            });
            Application.Current.MainPage.Navigation.PopAsync();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
