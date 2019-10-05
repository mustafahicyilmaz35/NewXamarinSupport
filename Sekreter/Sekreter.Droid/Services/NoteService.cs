using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Sekreter.Core.Interfaces;
using Sekreter.Droid.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(NoteService))]
namespace Sekreter.Droid.Services
{
    public class NoteService : Activity, INoteService
    {
        [Obsolete]
        public Task<bool> NotepadLaunch(string notes)
        {
            Intent intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage("notes.notebook.memo.pad.color.notepad.locker");
            try
            {
                if (intent != null)
                {

                    intent.AddFlags(ActivityFlags.NewTask);
                    intent.PutExtra(Intent.ExtraText, notes);
                    Forms.Context.StartActivity(intent);
                }
                else
                {
                    intent = new Intent(Intent.ActionView);
                    intent.AddFlags(ActivityFlags.NewTask);
                    intent.SetData(Android.Net.Uri.Parse("market://details?id=notes.notebook.memo.pad.color.notepad.locker")); // This launches the PlayStore and search for the app if it's not installed on your device

                }
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {

                return Task.FromResult(false);
            }
        }
    }
}