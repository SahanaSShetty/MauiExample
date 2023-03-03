using Microsoft.Maui.Controls.Compatibility;

namespace MauiAppFocusIssue;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
    async void OnButtonClicked(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new NewRelativePage());
    }


}

