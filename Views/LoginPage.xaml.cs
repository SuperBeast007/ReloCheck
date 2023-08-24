using ReloCheck.Resources.ViewModels;

using System;
using Microsoft.Maui.Controls;

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
}


