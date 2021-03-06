﻿using OutlookProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OutlookProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailSendPage : ContentPage
    {
        public EmailSendPage()
        {
            InitializeComponent();
        }

        void onSendButtonClicked(object sender, EventArgs e)
        {


            //DependencyService.Get<ILaunchApp>().Launch("https://outlook.office.com/api/v2.0", entry_mailAdress.Text, entry_cc.Text, entry_subject.Text, entry_message.Text);

            
                //DependencyService.Get<IOutlookService>().Launch("com.microsoft.office.outlook", entry_mailAdress.Text, entry_cc.Text, entry_subject.Text, entry_message.Text);
                DependencyService.Get<IOutlookService>().Launch("com.microsoft.office.outlook", entry_mailAdress.Text, entry_cc.Text, entry_subject.Text, entry_message.Text);
            
        }

        void OnNotesButtonClicked(object sender, EventArgs e)
        {
            DependencyService.Get<INotePadService>().NotepadLaunch(entry_notes.Text);
        }
    }
}