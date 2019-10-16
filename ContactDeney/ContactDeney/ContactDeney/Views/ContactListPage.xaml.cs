using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactDeney.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactDeney.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactListPage : ContentPage
    {
        public ContactListPage()
        {
            InitializeComponent();
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                lst_Contact.ItemsSource = (BindingContext as ContactListViewModel).ContactItems;
                

            }
            else
            {
                lst_Contact.ItemsSource =
                    (BindingContext as ContactListViewModel).ContactItems.Where(c =>
                        c.FirstName.ToLower().StartsWith(e.NewTextValue.ToLower()));
            }
        }
    }
}