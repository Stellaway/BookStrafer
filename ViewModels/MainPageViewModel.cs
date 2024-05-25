using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using Cookbook.Views;

namespace Cookbook.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public void NavigateToResults(string searchTerm)
        {
            //Template10.Services.NavigationService.NavigationService.GetForFrame(Window.Current.Content as Frame).Navigate(typeof(ResultsPage), searchTerm);
            NavigationService.Navigate(typeof(ResultsPage), searchTerm);
        }
    }
}

