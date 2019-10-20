using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Navigo.Core.ViewModels
{
    public class NextViewModel:MvxViewModel<string>
    {
        //Properties
        private readonly IMvxNavigationService _navigationService;
        private string _helloWorld;

        public string HelloWorld
        {
            get => _helloWorld;
            set
            {
                _helloWorld = value;
                RaisePropertyChanged(() => HelloWorld);
            }
        }

        //Constructor
        public NextViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public override void Prepare(string parameter)
        {
            HelloWorld = parameter;
        }

        //MvvmCross Methods
        public override Task Initialize() => base.Initialize();

        //Commands
        public IMvxCommand BackCommand => new MvxCommand(BackAsync);

        private async void BackAsync()
        {
            await _navigationService.Close(this);
        }
    }
}
