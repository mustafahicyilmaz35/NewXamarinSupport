using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using ContactDeney.Annotations;
using ContactDeney.Models;
using ContactDeney.Services;
using ContactDeney.Views;
using Xamarin.Forms;

namespace ContactDeney.ViewModels
{
    class ContactListViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ContactItem> ContactItems { get; private set; }

        
        

        private string _searchedText;

        public string SearchedText
        {
            get { return _searchedText; }
            set
            {
                _searchedText = value;
                OnPropertyChanged(nameof(SearchedText));
            }
        }

        public ICommand AddNewCommand { get; private set; }
        //public ICommand SearchCommand { get; private set; }


        public ContactListViewModel()
        {
            ContactItems = new ObservableCollection<ContactItem>();
            ContactItems.Add(new ContactItem
            {
                FirstName = "Mustafa",
                LastName = "Hiçyılmaz"
            });

            AddNewCommand = new Command(AddNewAction);
            //SearchCommand = new Command(SearchCommandExecute);
        }

        /*private void SearchCommandExecute()
        {
            if (SearchedText != null)
            {
                var query = ContactItems.Where(c => c.FirstName.StartsWith(SearchedText));
                foreach (var item in query)
                {
                    ContactItems.Add(item);                    
                }
            }

            
        }*/

        void AddNewAction()
        {
            Application.Current.MainPage.Navigation.PushAsync(new AddContactPage(ContactItems));
        }



       
        


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
