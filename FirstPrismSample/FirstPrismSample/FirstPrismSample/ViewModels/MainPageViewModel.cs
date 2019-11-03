using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirstPrismSample.Models;

namespace FirstPrismSample.ViewModels
{
    public class MainPageViewModel : BindableBase
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

        //ctor
        public MainPageViewModel(INavigationService navigationService)
        {
            Title = "Xamarin Forms Prism Main Page";
            People = new List<Person>();
            People.Add(new Person
            {
                Name = "Mustafa"
            });
            People.Add(new Person
            {
                Name = "Hasan"
            });
            _navigationService = navigationService;
        }

        private DelegateCommand _navigationCommand;

        public DelegateCommand NavigationCommand =>
            _navigationCommand ?? (new DelegateCommand(NavigateCommandActionAsync));

        private async void NavigateCommandActionAsync()
        {
            var param = new NavigationParameters();
            param.Add("people",People);
            await _navigationService.NavigateAsync("ViewA", param);
            

        }
    }
}
