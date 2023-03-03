using MauiPopup;

namespace MauiPopupDemo;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
         await PopupAction.DisplayPopup(new PopupPage());

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

