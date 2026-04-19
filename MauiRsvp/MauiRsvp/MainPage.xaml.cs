namespace MauiRsvp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object? sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(EmailEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
            {
                string user = EmailEntry.Text;
                string pass = PasswordEntry.Text;

                if(user == "admin" && pass == "password")
                {
                    Navigation.PushAsync(new HomePage());
                }
                else
                {
                    ErrorLbl.Text = "Invalid username or password. Please try again.";
                }
            }
            else
            {
                    ErrorLbl.Text = "Please enter both username and password.";
            }
        }

        private void OnRegisterClicked(object? sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
