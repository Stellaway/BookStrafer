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
using Windows.System;
using Windows.UI.Xaml.Navigation;

namespace Cookbook.ViewModels
{
    public class DetailsPageViewModel : ViewModelBase
    {
        private Book _book;
        public Book Book
        {
            get { return _book; }
            set { Set(ref _book, value); }
        }
        private string _mediumCover;

        private string _largeCover;

        public string MediumCover
        {
            get { return _mediumCover; }
            set { Set(ref _mediumCover, value); }
        }
        public string LargeCover
        {
            get { return _largeCover; }
            set { Set(ref _largeCover, value); }
        }
        public bool IsCoverClicked = false;
        public ObservableCollection<Author> Authors { get; set; } = new ObservableCollection<Author>(); 

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            var service = new BooksearchService();

            try
            {
                Book = await service.GetBookAsync((string)parameter);

                MediumCover = $"https://covers.openlibrary.org/b/id/{Book.covers.FirstOrDefault()}-M.jpg";
                LargeCover = $"https://covers.openlibrary.org/b/id/{Book.covers.FirstOrDefault()}-L.jpg";

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            //cycle through the author keys and get the author details
            if (Book != null)
            {
                foreach (var author in Book.authors)
                {
                    try
                    {
                        var authorGot = await service.GetAuthorAsync(author.author.key);
                        Authors.Add(authorGot);
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                } 
            }


            await base.OnNavigatedToAsync(parameter, mode, state);

        }

        /// <summary>
        /// opens a website in the default browser
        /// </summary>
        /// <param name="url"></param>
        public void OpenWebsiteAsync(string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
            {
                _ = Launcher.LaunchUriAsync(uri);
            }
            else
            {
                Debug.WriteLine("Invalid URL");
            }
        }
    }


}
