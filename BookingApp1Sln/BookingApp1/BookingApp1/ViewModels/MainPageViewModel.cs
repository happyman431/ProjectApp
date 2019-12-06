using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";
      
        }


        async void ExecuteNavigateCommand()
        {
            await NavigationService.NavigateAsync("SignUpPage");

        }
    }
}


        
            
        
       
    
