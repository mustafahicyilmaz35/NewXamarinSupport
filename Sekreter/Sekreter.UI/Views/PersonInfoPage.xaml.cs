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
    public partial class PersonInfoPage : ContentPage
    {
        public PersonInfoPage()
        {
            InitializeComponent();
        }
        public PersonInfoPage(string name, string number, string emailadress)
        {
            InitializeComponent();
            label_name.Text = name;
            label_phonenumber.Text = number;
            if(emailadress == null)
            {
                label_emailadress.Text = "Email Adresi Kayıtlı Değildir.";
            }
            else
            {
                label_emailadress.Text = emailadress;
            }
           
        }
    }
}