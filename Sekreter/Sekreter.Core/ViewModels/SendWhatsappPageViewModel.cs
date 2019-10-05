using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms.OpenWhatsApp;

namespace Sekreter.Core.ViewModels
{
    public class SendWhatsappPageViewModel
    {
        public SendWhatsappPageViewModel(string number, string textMessage)
        {
            SendWhatsappMessage(number, textMessage);
        }

        void SendWhatsappMessage(string number, string textMessage)
        {
            try
            {
                Chat.Open(number, textMessage);
            }
            catch (Exception e)
            {

                Debug.WriteLine(e.Message);
            }
        }
    }
}
