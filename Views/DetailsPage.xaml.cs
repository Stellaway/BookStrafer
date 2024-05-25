using Cookbook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Cookbook.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetailsPage : Page
    {
        public DetailsPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// lets the user click on the name of the author to be sent to the page of the author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Author_ItemClick(object sender, ItemClickEventArgs e)
        {
            var author = (Author)e.ClickedItem;
            ViewModel.OpenWebsiteAsync("https://openlibrary.org/"+ author.key);
        }


        /// <summary>
        /// makes it able for image to be clicked and zoomed in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickableCover_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (!ViewModel.IsCoverClicked)
            {
                clickableCover.Source = new BitmapImage(new Uri(ViewModel.LargeCover));
                clickableCover.Height = 400;
                ViewModel.IsCoverClicked = true;
            }
            else
            {
                clickableCover.Source = new BitmapImage(new Uri(ViewModel.MediumCover));
                clickableCover.Height = 200;
                ViewModel.IsCoverClicked = false;  
            }
        }
    }
}
