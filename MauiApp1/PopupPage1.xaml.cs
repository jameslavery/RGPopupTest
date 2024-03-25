using RGPopup.Maui.Pages;
using System.Diagnostics;
using System.Windows.Input;

namespace MauiApp1;

public partial class PopupPage1 : PopupPage
{
	public ICommand LabelTappedCommand { get; set; }
	public ICommand ButtonCommand { get; set; }
    public ICommand ButtonGestureCommand { get; set; }

	public PopupPage1()
	{
		InitializeComponent();
		BindingContext = this;

		LabelTappedCommand = new Command(HandleTap);
        ButtonCommand = new Command(HandleButton);
        ButtonGestureCommand = new Command(HandleButtonGesture);
	}

    private void HandleButton(object obj)
    {
        Debug.WriteLine("PopupPage1.Button Command executed");
    }

    private void HandleButtonGesture(object obj)
    {
        Debug.WriteLine("PopupPage1.Button Gesture executed");
    }

    private void HandleTap(object obj)
    {
		Debug.WriteLine("PopupPage1.Label TapCommand executed");
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Debug.WriteLine("PopupPage1.Label tapped");

    }
}