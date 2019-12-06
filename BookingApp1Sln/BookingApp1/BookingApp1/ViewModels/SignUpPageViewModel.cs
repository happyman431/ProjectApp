using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookingApp1.ViewModels
{
    public class SignUpPageViewModel : ViewModelBase
    {

        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public SignUpPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Sign Up Page";

        }

         async void ExecuteNavigateCommand()
        {
            await NavigationService.NavigateAsync("MainPage");


        
        
        


        }
    }
}
