using BookStrafer.Models;
using BookStrafer.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Windows.UI.Xaml.Navigation;
using static BookStrafer.Models.SearchResult;

namespace BookStrafer.ViewModels
{
    public class ResultsPageViewModel : ViewModelBase
    {
        public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();

        private SearchResult _searchResult;

        public SearchResult searchResult
        {
            get { return _searchResult; }
            set { Set(ref _searchResult, value); }
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            var searchTerm = (string)parameter;
            var service = new BooksearchService();
            searchResult = await service.GetSearchResultsAsync(searchTerm);
            foreach (var item in searchResult.books)
            {
                Books.Add(item);
            }
            await base.OnNavigatedToAsync(parameter, mode, state);
        }

    }
}
