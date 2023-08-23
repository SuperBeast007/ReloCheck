namespace ReloCheck;

public partial class AppShell : Shell
{
    private NavigationPage MainPage;

    public AppShell()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new ReloCheck.Views.LoginPage());
        MainPage = new NavigationPage(new MainPage());
    }
}
