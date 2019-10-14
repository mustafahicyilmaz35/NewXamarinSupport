using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using ContactDeney.Annotations;
using ContactDeney.Models;
using ContactDeney.Views;
using Xamarin.Forms;

namespace ContactDeney.ViewModels
{
    class ContactListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ContactItem> ContactItems { get; private set; }

        public ICommand AddNewCommand { get; private set; }

        public ContactListViewModel()
        {
            ContactItems = new ObservableCollection<ContactItem>();
            ContactItems.Add(new ContactItem
            {
                FirstName = "Mustafa",
                LastName = "Hiçyılmaz"
            });

            AddNewCommand = new Command(AddNewAction);
        }

        void AddNewAction()
        {
            Application.Current.MainPage.Navigation.PushAsync(new AddContactPage(ContactItems));
        }





        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
