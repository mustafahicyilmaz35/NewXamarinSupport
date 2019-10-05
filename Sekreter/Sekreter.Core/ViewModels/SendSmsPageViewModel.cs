using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Sekreter.Core.ViewModels
{
    public class SendSmsPageViewModel
    {
       

       // public string messageText { get; set; }
       // public string recipient { get; set; }



        public ICommand smsCommand { private set; get; }

        public SendSmsPageViewModel()
        {
            //smsCommand = new Command(() => SendSms(messageText, recipient));
        }


       public SendSmsPageViewModel(string _messageText, string _recipient)
        {
            
               // messageText = _messageText;
                //recipient = _recipient;
                



                SendSms(_messageText, _recipient);
        }

        public async Task SendSms(string messageText, string recipient)
        {
            try
            {
                var message = new SmsMessage(messageText, new[] { recipient });
                await Sms.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException e)
            {

                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

        }
    }
}
