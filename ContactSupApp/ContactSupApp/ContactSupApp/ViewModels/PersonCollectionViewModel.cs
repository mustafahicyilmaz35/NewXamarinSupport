using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using ContactSupApp.Annotations;
using Xamarin.Forms;

namespace ContactSupApp.ViewModels
{
    public class PersonCollectionViewModel : INotifyPropertyChanged
    {
        //properties
        private PersonViewModel personEdit;
        private bool isEditing;



        //Encapsulation

        public PersonViewModel PersonEdit
        {
            get => personEdit;
            set => SetProperty(ref personEdit, value);
        }

        public bool IsEditing
        {
            get => isEditing;
            set => SetProperty(ref isEditing, value);
        }

        public IList<PersonViewModel> Persons { get; } = new ObservableCollection<PersonViewModel>();

        //Commands
        public ICommand NewCommand { private set; get; }
        public ICommand SubmitCommand { private set; get; }
        public ICommand CancelCommand { private set; get; }

        public PersonCollectionViewModel()
        {
               NewCommand = new Command(() =>
               {
                   PersonEdit = new PersonViewModel();
                   PersonEdit.PropertyChanged += OnPersonEditPropertyChanged;
                   IsEditing = true;
                   RefreshCanExecute();
               },
                   () => { return !IsEditing; }); 

               SubmitCommand = new Command(() =>
               {
                   Persons.Add(PersonEdit);
                   PersonEdit.PropertyChanged -= OnPersonEditPropertyChanged;
                   PersonEdit = null;
                   IsEditing = false;
                   RefreshCanExecute();
               }, () =>
                   {
                       return PersonEdit != null && PersonEdit.Name != null && PersonEdit.Name.Length > 1 &&
                              PersonEdit.Age > 0;
                   });

               CancelCommand = new Command(() =>
               {
                   PersonEdit.PropertyChanged -= OnPersonEditPropertyChanged;
                   PersonEdit = null;
                   IsEditing = false;
                   RefreshCanExecute();
               }, () => { return IsEditing; });
        }



        //PropertyChanged Event
        public event PropertyChangedEventHandler PropertyChanged;

        



        //PropertyChanged Methods
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        void OnPersonEditPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            (SubmitCommand as Command).ChangeCanExecute();
        }

        void RefreshCanExecute()
        {
            (NewCommand as Command).ChangeCanExecute();
            (SubmitCommand as Command).ChangeCanExecute();
            (CancelCommand as Command).ChangeCanExecute();
        }
    }
}
