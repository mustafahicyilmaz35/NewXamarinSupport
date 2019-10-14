using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactDeney.Models;
using ContactDeney.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactDeney.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage(ObservableCollection<ContactItem> contactItems)
        {
            InitializeComponent();
            this.BindingContext = new AddContactViewModel(contactItems);
        }
    }
}