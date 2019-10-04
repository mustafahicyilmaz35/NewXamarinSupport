using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Forms.Views;
using Sekreter.Core.Models;
using Sekreter.Core.ViewModels.Call;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sekreter.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CallPage : MvxContentPage<CallPageViewModel>
    {
        

        public CallPage()
        {
            InitializeComponent();
            BindingContext = new PhoneContact();
            
        }

        void OnCallClicked(object sender, EventArgs e)
        {
            PhoneDialer.Open(label_phonenumber.Text);
        }
    }
}
