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
    public partial class OutlookPage : ContentPage
    {
        public OutlookPage()
        {
            InitializeComponent();
        }

        public OutlookPage(string emailadress)
        {
            InitializeComponent();
            label_mailAdress.Text = emailadress;
            

        }

        void OnOutlookButtonClicked(object sender, EventArgs e)
        {
            BindingContext = new OutlookPageViewModel(label_mailAdress.Text, null, entry_subject.Text, entry_message.Text);
        }
    }
}