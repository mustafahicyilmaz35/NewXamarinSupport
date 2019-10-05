using Sekreter.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Sekreter.Core.ViewModels
{
    public class NoteViewModel
    {
        public NoteViewModel()
        {
            DependencyService.Get<INoteService>().NotepadLaunch("Not Defteri");
        }
    }
}
