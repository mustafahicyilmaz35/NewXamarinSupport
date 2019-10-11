using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using ContactSupApp.Annotations;

namespace ContactSupApp.ViewModels
{
    public class PersonViewModel:INotifyPropertyChanged
    {
        //Properties

        private string name;
        private double age;
        private string skills;


        //Encapsulation
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public double Age
        {
            get => age;
            set => SetProperty(ref age, value);
        }

        public string Skills
        {
            get => skills;
            set => SetProperty(ref skills, value);
        }

        public override string ToString()
        {
            return Name + " age " + Age;
        }

        //PropertyChanged Event
        public event PropertyChangedEventHandler PropertyChanged;

        

        //PropertyChanged Methods
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        bool SetProperty<T>(ref T storage, T value,[CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
