using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Essentials;

namespace Sekreter.Core.ViewModels
{
    public class MainContactViewModel
    {
        public MainContactViewModel()
        {

        }

        public MainContactViewModel(string number)
        {
            PhoneCaller(number);
        }

        public void PhoneCaller(string number)
        {
            try
            {
                PhoneDialer.Open(number);
            }
            catch (ArgumentNullException e)
            {

                Debug.WriteLine(e.Message);
            }
            catch(FeatureNotSupportedException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
