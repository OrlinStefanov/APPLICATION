namespace Code_Legend;

public partial class Fundaments : ContentPage
{
	public Fundaments()
	{
		InitializeComponent();
	}

    private async void TemplatesBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Templates_Fundamentals());
    }

    private async void DataBindingBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DataBinding_Fundamentals());
    }

    private void FistStepsBtn_Clicked(object sender, EventArgs e)
    {

    }
}