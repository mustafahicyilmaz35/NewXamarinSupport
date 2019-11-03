using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace FirstPrismSample.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _title;
        private readonly INavigationService _navigationService;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        public ViewBViewModel(INavigationService navigationService)
        {
            Title = "View B";
            _navigationService = navigationService;
        }

        private DelegateCommand _navigationCommand;

        public DelegateCommand NavigationCommand =>
            _navigationCommand ?? (_navigationCommand = new DelegateCommand(NavigationActionAsync));

        private async void NavigationActionAsync()
        {
            await _navigationService.NavigateAsync("MainPage");
        }
    }
}
