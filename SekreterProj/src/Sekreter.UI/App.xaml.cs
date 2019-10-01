using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sekreter.UI.Pages;
using Xamarin.Forms;

namespace Sekreter.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ContactPage();
        }
    }
}
