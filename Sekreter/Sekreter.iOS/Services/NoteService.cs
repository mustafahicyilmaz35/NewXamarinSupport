using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using Sekreter.Core.Interfaces;
using Sekreter.iOS.Services;
using UIKit;

[assembly:Xamarin.Forms.Dependency(typeof(NoteService))]
namespace Sekreter.iOS.Services
{
    public class NoteService : INoteService
    {
        [Obsolete]
        public Task<bool> NotepadLaunch(string notes)
        {
            try
            {
                var stringUri = ""; //Uygulamanın url scheme ini bulamadım.
                var format = stringUri + "";
                var uri = new NSUrl(format);
                if(UIApplication.SharedApplication.CanOpenUrl(uri))
                {
                    UIApplication.SharedApplication.OpenUrl(uri);
                }
                else
                {
                    Debug.WriteLine("Can not URL");
                }
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {

                var alertView = new UIAlertView("Error", ex.Message, null, "OK", null);

                alertView.Show();

                return Task.FromResult(false);
            }
        }
    }
}