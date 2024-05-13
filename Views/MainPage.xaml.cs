using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BookStrafer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string helloText = "Welcome to BookStrafer!";
        string beOurGuestText = "Please, be our guest and search for any books!";

        public MainPage()
        {
            InitializeComponent();
            StartTypingAnimation();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var frame = Window.Current.Content as Frame;

            ViewModel.NavigateToResults(txtSearch.Text);
        }

        /// <summary>
        /// This creates a typing animation for the greeting text
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

    }
}
