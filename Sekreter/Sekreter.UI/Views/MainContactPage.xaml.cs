using Sekreter.Core.Interfaces;
using Sekreter.Core.Models;
using Sekreter.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sekreter.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainContactPage : ContentPage
    {
        public MainContactPage()
        {
            InitializeComponent();
            lst_Contacts.ItemsSource = DependencyService.Get<IContactService>().GetContactList();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                var actionSheet = await DisplayActionSheet("Yapmak İstediğiniz işlemi Seçin.", "İptal", null, "Ara", "Sms Mesajı Gönder", "Whatsapp Mesajı Gönder", "E-Posta Gönder", "Not Ekle", "Kişi Bilgisi");
                switch(actionSheet)
                {
                    case "Ara":
                        BindingContext = new MainContactViewModel((e.SelectedItem as Contact).Number);
                        break;
                    case "Sms Mesajı Gönder":
                        await DisplayAlert("Deneme", "Sms", "OK", "CANCEL");
                        break;
                    case "Whatsapp Mesajı Gönder":

                        break;
                    case "E-Posta Gönder":

                        break;
                    case "Not Ekle":

                        break;
                    case "Kişi Bilgisi":

                        break;



                }
            }
        }
    }
}