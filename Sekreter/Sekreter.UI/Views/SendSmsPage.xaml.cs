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
    public partial class SendSmsPage : ContentPage
    {
        public SendSmsPage()
        {
            InitializeComponent();
           
        }

        

        //e.SelectedItem buradayken
        public SendSmsPage(string _recipient)
        {
            
            InitializeComponent();
            label_smsname.Text = _recipient;
           
            
        }

        void OnSendSmsClicked(object sender, EventArgs e)
        {
            BindingContext = new SendSmsPageViewModel(entry_smstext.Text,label_smsname.Text);
        }
    }
}