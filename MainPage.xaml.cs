using System.Collections.Generic;
using ReloCheck.Resources.ViewModels;
using ReloCheck.Views;
using Microsoft.Maui.Controls;

namespace ReloCheck
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void Login(object sender, EventArgs e)
        {
            // Navigate to the SecondPage when the button is clicked
            await Navigation.PushAsync(new RoomDetailss());

        }
    }

}



