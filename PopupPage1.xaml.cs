using MauiPopup;
using MauiPopup.Views;

namespace MauiPopupDemo;

public partial class PopupPage1 : BasePopupPage
{
	public PopupPage1()
	{
		InitializeComponent();
	}
   
    private async void btnYes_Clicked(object sender, EventArgs e)
    {
        await PopupAction.ClosePopup();
    }

    private void btnNo_Clicked(object sender, EventArgs e)
    {

    }
}