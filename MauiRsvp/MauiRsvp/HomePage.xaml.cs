namespace MauiRsvp;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private void OnHomeClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HomePage());
    }

    private void OnRsvpClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RsvpPage());
    }

    private void OnInfoClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InfoPage());
    }

    private void OnCreateClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CreatePage());
    }

    private void OnLogOutClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}