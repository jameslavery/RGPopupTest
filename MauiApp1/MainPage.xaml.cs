using RGPopup.Maui.Services;
using System.Diagnostics;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopupPage1());
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            Debug.WriteLine("MainPage.Label tapped");

        }
    }

}
