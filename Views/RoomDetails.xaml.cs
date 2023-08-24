using System.Collections.Generic;
using ReloCheck.Resources.ViewModels;
using ReloCheck.Views;
using Microsoft.Maui.Controls;

namespace ReloCheck.Views;

public partial class RoomDetailss : ContentPage
{
	public RoomDetailss()
	{
		InitializeComponent();


        //List<Room> rooms = new List<Room>
        //    {
        //    new Room { RoomName = "Living Room", TotalItems = 15, Thumbnail = "None"},
        //    new Room { RoomName = "Kitchen", TotalItems = 10, Thumbnail = "None"},
        //    new Room { RoomName = "Main Bedroom", TotalItems = 22, Thumbnail = "None"},
        //    new Room { RoomName = "Bedroom 1", TotalItems = 12, Thumbnail = "None"},
        //    new Room { RoomName = "Bathroom 1", TotalItems = 5, Thumbnail = "None"},
        //    new Room { RoomName = "Bathroom 2", TotalItems = 7, Thumbnail = "None"},
        //    new Room { RoomName = "Garage", TotalItems = 56, Thumbnail = "None"},
        //    };

        //roomListView.ItemsSource = rooms;

    }

    private async void OnButtonClick(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new AddRoom());

    }
}