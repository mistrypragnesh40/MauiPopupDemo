using MauiPopup;
using MauiPopup.Views;
namespace MauiPopupDemo;

public partial class PopupPage : BasePopupPage
{
	public PopupPage()
	{
		InitializeComponent();
	}

    private async void btnYes_Clicked(object sender, EventArgs e)
    {
        await PopupAction.DisplayPopup(new PopupPage1());
    }

    private async void btnNo_Clicked(object sender, EventArgs e)
    {
        await PopupAction.ClosePopup();
    }
}