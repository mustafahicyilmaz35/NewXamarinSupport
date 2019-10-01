using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Forms.Platforms.Android.Views;
using Sekreter.Core.ViewModels.Main;

namespace Sekreter.Droid
{
    [Activity(
        Theme = "@style/AppTheme")]
    public class MainActivity : MvxFormsAppCompatActivity<MainViewModel>
    {

        readonly string[] Permissions = {
            Manifest.Permission.WriteContacts,
            Manifest.Permission.ReadContacts
        };
        const int requestCode = 0;

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            RequestPermissions(Permissions, requestCode);
        }
    }
}
