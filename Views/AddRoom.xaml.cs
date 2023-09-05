using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReloCheck.Resources.ViewModels;
using ReloCheck.Views;
using Microsoft.Maui.Controls;
using MySql.Data.MySqlClient;
using System.Data;

namespace ReloCheck.Views;

public partial class AddRoom : ContentPage
{
	public AddRoom()
	{
		InitializeComponent();
	}

    string MyConnectionString = @"server=LAPTOP-UPC09RTU;userid=default;password=default;database=MoverSynq ";


    private async void OnSaveButton(object sender, EventArgs e)
	{

		//string RoomName = RoomEntry.Text;
		
		//MySqlConnection connection = new MySqlConnection(MyConnectionString);
		//MySqlCommand cmd;
		//connection.Open();

		//try
		//{
		//	cmd = connection.CreateCommand();
		//	cmd.CommandText = "INSERT INTO ROOMS(Name)VALUES(@Name)";
		//	cmd.Parameters.AddWithValue("@Name", RoomEntry.Text);
		//	cmd.ExecuteNonQuery();
		//} catch (Exception) 
		//{
		//	throw;
		//} finally
		//{
		//	if (connection.State == ConnectionState.Open)
		//	{
		//		connection.Close();
		//	}
		//}
    }
}