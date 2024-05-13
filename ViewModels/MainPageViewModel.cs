using BookStrafer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace BookStrafer.ViewModels
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
