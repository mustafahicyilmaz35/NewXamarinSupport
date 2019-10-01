using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sekreter.Core.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sekreter.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            contact_lstView.ItemsSource = DependencyService.Get<IContactService>().GetAllContact();
        }
    }
}
