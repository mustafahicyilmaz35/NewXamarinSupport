using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using FirstPrismSample.Models;
using Prism.Navigation;

namespace FirstPrismSample.ViewModels
{
    public class ViewAViewModel : BindableBase, INavigatedAware
    {
        private string _title;
        private readonly INavigationService _navigationService;
        private List<Person> _people;

        public List<Person> People
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }
        
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        public ViewAViewModel(INavigationService navigationService)
        {
            Title = "View A";
            _navigationService = navigationService;
        }

        private DelegateCommand _navigationCommand;

        public DelegateCommand NavigationCommand =>
            _navigationCommand ?? (_navigationCommand = new DelegateCommand(NavigateCommandActionAsync));

        private async void NavigateCommandActionAsync()
        {
            await _navigationService.NavigateAsync("ViewB");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            People = parameters.GetValue<List<Person>>("people");
        }
    }
}
