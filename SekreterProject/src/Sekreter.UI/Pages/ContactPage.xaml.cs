using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Sekreter.Core.Interfaces;
using Sekreter.Core.Models;
using Sekreter.Core.ViewModels.Call;
using Sekreter.Core.ViewModels.Contact;
using Xamarin.Essentials;
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

        async void  OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
             var actionSheet = await DisplayActionSheet("Yapmak İstediğniz İşlemi Seçiniz", "İptal", null, "Arama Yap", "Sms Mesajı Gönder","Whatsap Mesajı Gönder","E-Posta Gönder","Kişi Bilgisi");
            /* if(actionSheet == "Arama Yap")
             {
                 await DisplayAlert("Deneme", "Arama Yap", "OK", "Cancel");
             }
             if (actionSheet == "Sms Mesajı Gönder")
             {
                 await DisplayAlert("Deneme", "Sms Mesajı Gönder", "OK", "Cancel");
             }
             if (actionSheet == "Whatsap Mesajı Gönder")
             {
                 await DisplayAlert("Deneme", "Whatsap Mesajı Gönder", "OK", "Cancel");
             }
             if (actionSheet == "E-Posta Gönder")
             {
                 await DisplayAlert("Deneme", "E-Posta Gönder", "OK", "Cancel");
             }
             if (actionSheet == "Kişi Bilgisi")
             {
                 await DisplayAlert("Deneme", "Kişi Bilgisi", "OK", "Cancel");
             }*/

            if (e.SelectedItem != null)
            {
                switch (actionSheet)
                {
                    case "Arama Yap":
                        await Navigation.PushAsync(new CallPage
                        {

                            MvxBindingContext = e.SelectedItem as PhoneContact
                        });
                        ;
                        break;
                    case "Sms Mesajı Gönder":
                        await DisplayAlert("Deneme", "Sms Mesajı Gönder", "OK", "Cancel");
                        break;
                    case "Whatsap Mesajı Gönder":
                        await DisplayAlert("Deneme", "Whatsap Mesajı Gönder", "OK", "Cancel");
                        break;
                    case "E-Posta Gönder":
                        await DisplayAlert("Deneme", "E-Posta Gönder", "OK", "Cancel");
                        break;
                    case "Kişi Bilgisi":
                        await DisplayAlert("Deneme", "Kişi Bilgisi", "OK", "Cancel");
                        break;
                }
            }
        }
        
    }
}
