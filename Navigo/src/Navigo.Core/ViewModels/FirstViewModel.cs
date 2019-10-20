using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Navigo.Core.ViewModels
{
    public class FirstViewModel:MvxViewModel
    {
        //Properties
        private readonly IMvxNavigationService _navigationService;
        private string helloString = "Hello!";


        //Const
        public FirstViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        //MvvmCross Methods
        public override Task Initialize() => base.Initialize();

        //Commands
        public IMvxCommand NavigateCommand => new MvxCommand(NavigateAsync);
        public IMvxCommand NavigateParameterCommand => new MvxCommand(NavigateParameterAsync);

        private async void NavigateParameterAsync()
        {
            await _navigationService.Navigate<NextViewModel, string>(helloString);
        }

        private async void NavigateAsync()
        {
            await _navigationService.Navigate<NextViewModel>();
        }
    }
}
