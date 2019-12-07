using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookingApp1.ViewModels
{
    public class SignInPageViewModel : ViewModelBase
    {
        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public SignInPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Sign In Page";

        }

        async void ExecuteNavigateCommand()
        {
            await NavigationService.NavigateAsync("MainPage");







        }
    }
}
