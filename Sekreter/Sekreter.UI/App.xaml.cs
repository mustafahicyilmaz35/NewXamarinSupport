﻿using Sekreter.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sekreter.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }
        protected override void OnStart()
        {
            //base.OnStart();
        }
        protected override void OnSleep()
        {
           // base.OnSleep();
        }
        protected override void OnResume()
        {
            //base.OnResume();
        }
    }
}