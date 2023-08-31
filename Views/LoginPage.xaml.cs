using ReloCheck.Resources.ViewModels;

using System;
using Microsoft.Maui.Controls;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ReloCheck.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

		BindingContext = new LoginViewModel();
	}

    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        //string connstring = @"server=LAPTOP-UPC09RTU;userid=default;password=default;database=MoverSynq ";

        //MySqlConnection conn = null;


        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;


        bool isLoginSuccessful = Login(email, password);

        if (isLoginSuccessful)
        {
            // Navigate to the main page


        }
        else
        {
            DisplayAlert("Login Failed", "Invalid email or password. Please try again.", "OK");
        }
    }

    private bool Login(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            // Username or password is empty or contains only whitespace.
            return false;
        }


        // Need to link to database for security
        return email == "Test@gmail.com" && password == "password";
    }
    private async void OnForgotPasswordButtonClicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text;

        if (string.IsNullOrWhiteSpace(email))
        {
            await DisplayAlert("Invalid Email", "Please enter a valid email address.", "OK");
            return;
        }

        bool isEmailSent = SendPasswordEmail(email);

        if (isEmailSent)
        {
            await DisplayAlert("Email Sent", "An email with your username and password has been sent.", "OK");
        }
        else
        {
            await DisplayAlert("Email Sending Failed", "There was an issue sending the email. Please try again later.", "OK");
        }
    }

    private bool SendPasswordEmail(string email)
    {
        // Need API for mailer
        
        string username = "user";
        string password = "password";

        string emailBody = $"Username: {username}\nPassword: {password}";

        try
        {
            // Stand in till API is recieved
            Console.WriteLine($"Email sent to {email}:\n{emailBody}");
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }



    private async void OnGoogleClicked(object sender, EventArgs e)
    {
        try
        {
            WebAuthenticatorResult authResult = await WebAuthenticator.Default.AuthenticateAsync(
                new WebAuthenticatorOptions()
                {
                    Url = new Uri("https://ReloCheck.com/mobileauth/Microsoft"),
                    CallbackUrl = new Uri("ReloCheck://"),
                    PrefersEphemeralWebBrowserSession = true
                });
            string accessToken = authResult?.AccessToken;
        }
        catch (TaskCanceledException ef)
        {
            return;
        }
    }

    private async void OnFBClicked(object sender, EventArgs e)
    {

    }

    private async void OnAppleClicked(object sender, EventArgs e)
    {
        var scheme = "..."; // Apple, Microsoft, Google, Facebook, etc.
        var authUrlRoot = "https://mysite.com/mobileauth/";
        WebAuthenticatorResult result = null;

        if (scheme.Equals("Apple")
            && DeviceInfo.Platform == DevicePlatform.iOS
            && DeviceInfo.Version.Major >= 13)
        {
            // Use Native Apple Sign In API's
            result = await AppleSignInAuthenticator.AuthenticateAsync();
        }
        else
        {
            // Web Authentication flow
            var authUrl = new Uri($"{authUrlRoot}{scheme}");
            var callbackUrl = new Uri("ReloCheck://");

            result = await WebAuthenticator.Default.AuthenticateAsync(authUrl, callbackUrl);
        }

        var authToken = string.Empty;

        if (result.Properties.TryGetValue("name", out string name) && !string.IsNullOrEmpty(name))
            authToken += $"Name: {name}{Environment.NewLine}";

        if (result.Properties.TryGetValue("email", out string email) && !string.IsNullOrEmpty(email))
            authToken += $"Email: {email}{Environment.NewLine}";

        // Note that Apple Sign In has an IdToken and not an AccessToken
        authToken += result?.AccessToken ?? result?.IdToken;
    }
}


