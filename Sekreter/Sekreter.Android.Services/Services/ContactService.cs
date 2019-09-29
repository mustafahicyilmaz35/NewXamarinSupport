using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Sekreter.Android.Services.Services;
using Sekreter.Core.Interfaces;
using Sekreter.Core.Models;

[assembly:Xamarin.Forms.Dependency(typeof(ContactService))]
namespace Sekreter.Android.Services.Services
{
    public class ContactService : IContactService
    {
        [Obsolete]
        public IEnumerable<PhoneContacts> GetAllContacts()
        {
            PhoneContacts selectedContact = new PhoneContacts();
            List<PhoneContacts> contactList = new List<PhoneContacts>();
            var uri = ContactsContract.CommonDataKinds.Phone.ContentUri;
            string[] projection = { ContactsContract.Contacts.InterfaceConsts.Id, ContactsContract.Contacts.InterfaceConsts.DisplayName, ContactsContract.CommonDataKinds.Phone.Number };
            var cursor = Xamarin.Forms.Forms.Context.ContentResolver.Query(uri, projection, null, null, null);
            if (cursor.MoveToFirst())
            {
                do
                {
                    contactList.Add(new PhoneContacts()
                    {
                        FirstName = cursor.GetString(cursor.GetColumnIndex(projection[1])),
                        PhoneNumber = cursor.GetString(cursor.GetColumnIndex(projection[2]))

                    });
                } while (cursor.MoveToNext());
            }
            return contactList;
        }
    }
}