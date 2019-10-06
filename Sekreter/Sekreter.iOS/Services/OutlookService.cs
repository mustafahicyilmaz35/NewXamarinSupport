using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using Sekreter.Core.Interfaces;
using UIKit;

namespace Sekreter.iOS.Services
{
    public class OutlookService : IOutlookService
    {
        [Obsolete]
        public Task<bool> Launch(string to, string cc, string subject, string text)
        {
            try
            {
                string stringUri = "ms-outlook://compose?to=example@email.com&subject=Subject&body=Message";
                var format = stringUri + "?to=" + to + "&subject=" + subject + "&body=" + text;
                var uri = new NSUrl(format);
                if (UIApplication.SharedApplication.CanOpenUrl(uri))
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