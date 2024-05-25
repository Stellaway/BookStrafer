using Cookbook.Models;
using Cookbook.Services;
using Cookbook.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Windows.UI.Xaml.Navigation;

namespace Cookbook.ViewModels
{
    public class ResultsPageViewModel : ViewModelBase
    {
        public ObservableCollection<SearchedBook> Books { get; set; } = new ObservableCollection<SearchedBook>();

        private SearchResult _searchResult;

        public SearchResult searchResult
        {
            get { return _searchResult; }
            set { Set(ref _searchResult, value); }
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            try
            {

                var searchTerm = (string)parameter;
                var service = new BooksearchService();
                searchResult = await service.GetSearchResultsAsync(searchTerm);
                try
                {
                    foreach (var item in searchResult.docs)
                    {
                        //setting the cover image
                        item.ddc_sort = $"https://covers.openlibrary.org/b/id/{item.cover_i}-M.jpg";
                        Books.Add(item);
                    }
                }
                catch (System.NullReferenceException e)
                {

                    Debug.WriteLine(e.Message);
                }
                await base.OnNavigatedToAsync(parameter, mode, state);
            }
            catch (Exception e)
            {

                Debug.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// navigates to the book's details page using the book key
        /// </summary>
        /// <param name="bookKey"></param>
        public void NavigateToDetails(string bookKey)
        {

            try
            {
                NavigationService.Navigate(typeof(DetailsPage), bookKey);
            }
            catch (Exception e)
            {

                Debug.WriteLine(e.Message);
            }
        }

    }
}
