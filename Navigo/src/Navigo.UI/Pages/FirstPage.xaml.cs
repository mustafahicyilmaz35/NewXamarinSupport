using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Views;
using Navigo.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigo.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MvxContentPage<FirstViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
