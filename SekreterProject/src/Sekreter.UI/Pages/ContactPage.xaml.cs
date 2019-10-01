using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Sekreter.Core.Interfaces;
using Sekreter.Core.ViewModels.Contact;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sekreter.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class ContactPage : MvxContentPage<ContactViewModel>
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            contact_lstView.ItemsSource = DependencyService.Get<IContactService>().GetAllContacts();
        }
    }
}
