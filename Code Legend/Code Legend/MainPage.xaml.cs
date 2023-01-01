namespace Code_Legend;
using Plugin.LocalNotification;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

        var result = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "Come back and learn more about .NET MAUI",
            Subtitle = "Learn .NET MAUI",
            Description = "There are a lot of lessons and test you hadn't done",
            BadgeNumber = 42,
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddHours(2),
                NotifyRepeatInterval = TimeSpan.FromDays(1),
            }
        };


        LocalNotificationCenter.Current.Show(result);
    }


    private async void UserInterfaceBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UserInterface());
    }

    private async void FundamentsBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Fundaments());
    }

    private async void Fundamentals2Btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Main_Basic());
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}

