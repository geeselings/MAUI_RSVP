namespace MauiRsvp;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private void OnRegisterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void OnReturnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
