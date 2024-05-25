using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Cookbook.Views
{
    public sealed partial class MainPage : Page
    {
        string helloText = "Welcome to BookStrafer!";
        string beOurGuestText = "Please, be our guest and search for any books!";

        public MainPage()
        {
            InitializeComponent();
            StartTypingAnimation();
        }

        /// <summary>
        /// makes the user able to click on the search button to search for books
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var frame = Window.Current.Content as Frame;

            ViewModel.NavigateToResults(txtSearch.Text);
        }

        /// <summary>
        /// this creates a typing animation for the greeting text
        /// </summary>
        private async void StartTypingAnimation()
        {
            await Task.Delay(1000);
            var currentCharIndex = 0;
            while (currentCharIndex < helloText.Length)
            {
                txtHelloText.Text += helloText[currentCharIndex];
                currentCharIndex++;
                await Task.Delay(50);
            }
            currentCharIndex = 0;

            while (currentCharIndex < beOurGuestText.Length)
            {
                txtBeOurGuestText.Text += beOurGuestText[currentCharIndex];
                currentCharIndex++;
                await Task.Delay(30);
            }
        }

        /// <summary>
        /// makes it able to press enter to search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
                btnSearch_Click(this, new RoutedEventArgs());
        }


    }
}
