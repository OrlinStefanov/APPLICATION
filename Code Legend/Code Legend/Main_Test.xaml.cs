namespace Code_Legend;

public partial class Main_Test : ContentPage
{
	public Main_Test()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new US_Test());
    }
}