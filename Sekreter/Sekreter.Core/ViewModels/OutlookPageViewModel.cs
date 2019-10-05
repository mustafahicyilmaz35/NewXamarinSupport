using Sekreter.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Sekreter.Core.ViewModels
{
    public class OutlookPageViewModel
    {


        public OutlookPageViewModel(string to, string cc, string subject, string text)
        {
            SendWithOutlook(to, cc, subject, text);
        }

        void SendWithOutlook(string to, string cc, string subject, string text)
        {
            DependencyService.Get<IOutlookService>().Launch(to, cc, subject, text);
        }
    }

    
}
