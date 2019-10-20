using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactCross.Core.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactCross.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactListPage : MvxContentPage<ContactListViewModel>
    {
        public ContactListPage()
        {
            InitializeComponent();
        }
    }
}
