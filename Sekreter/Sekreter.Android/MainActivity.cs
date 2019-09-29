using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Sekreter.UI;
using Android.Content.PM;
using Android;

namespace Sekreter.Android
{
    [Activity(Label = "Sekreter",  MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {


        readonly string[] Permissions = {
            Manifest.Permission.ReadContacts,
            Manifest.Permission.WriteContacts
        };
        const int requestCode = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {

           TabLayoutResource = Resource.Layout.Tabbar;
           ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            RequestPermissions(Permissions, requestCode);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}