using Sekreter.Core.Interfaces;
using Sekreter.Core.Models;
using Sekreter.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            //lst_Contacts.ItemsSource = DependencyService.Get<IContactService>().GetContactList();
            lst_Contacts.BindingContext = new GroupingViewModel();
        }

        void Searchbar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(e.NewTextValue))
            {
                lst_Contacts.ItemsSource = new GroupingViewModel().GroupData;
                
            }
            else
            {
                // lst_Contacts.ItemsSource = new GroupingViewModel().GroupData.
                lst_Contacts.ItemsSource = new GroupingViewModel().GroupData.Where(x => x.Any(y => y.Name.StartsWith(e.NewTextValue)));
            }
        }

        async void OnItemTap(object sender, ItemTappedEventArgs e)
        {
            if(e.Item != null)
            {
                var actionSheet = await DisplayActionSheet("Yapmak İstediğiniz işlemi Seçin.", "İptal", null, "Ara", "Sms Mesajı Gönder", "Whatsapp Mesajı Gönder", "E-Posta Gönder", "Not Ekle", "Kişi Bilgisi");
                switch(actionSheet)
                {
                    case "Ara":
                        BindingContext = new MainContactViewModel((e.Item as Contact).Number);
                        break;
                    case "Sms Mesajı Gönder":
                       await Navigation.PushAsync(new SendSmsPage((e.Item as Contact).Number));
                        break;
                    case "Whatsapp Mesajı Gönder":
                        await Navigation.PushAsync(new SendWhatsappPage((e.Item as Contact).Name, (e.Item as Contact).Number));
                        break;
                    case "E-Posta Gönder":
                        await Navigation.PushAsync(new OutlookPage((e.Item as Contact).Email));
                        break;
                    case "Not Ekle":
                        await Navigation.PushAsync(new NotePage());
                        break;
                    case "Kişi Bilgisi":
                        await Navigation.PushAsync(new PersonInfoPage((e.Item as Contact).Name,(e.Item as Contact).Number,(e.Item as Contact).Email));
                        break;



                }
            }
        }
    }
}