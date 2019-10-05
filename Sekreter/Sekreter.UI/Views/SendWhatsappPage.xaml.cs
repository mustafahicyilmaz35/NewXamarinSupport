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
    public partial class SendWhatsappPage : ContentPage
    {
        public SendWhatsappPage()
        {
            InitializeComponent();
        }

        public SendWhatsappPage(string name, string phoneNumber)
        {
            InitializeComponent();
            label_whatsappname.Text = phoneNumber;
            label_whatsappnumber.Text = name;
            
        }

        void OnSendWhatsappClicked(object sender, EventArgs e)
        {
           BindingContext = new SendWhatsappPageViewModel(label_whatsappname.Text,entry_whapsappmessage.Text);
        }
    }
}