using ReloCheck.Resources.ViewModels;

namespace ReloCheck.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

		BindingContext = new LoginViewModel();
	}

	

}