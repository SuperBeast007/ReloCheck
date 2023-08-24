namespace ReloCheck.Views;

public partial class AddRoom : ContentPage
{
	public AddRoom()
	{
		InitializeComponent();
	}

	private async void OnSaveButton(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new RoomDetailss());
    }
}