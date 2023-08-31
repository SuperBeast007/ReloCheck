using System.Collections.Generic;
using ReloCheck.Resources.ViewModels;
using ReloCheck.Views;
using Microsoft.Maui.Controls;
using MySql.Data.MySqlClient;
using System.Data;

namespace ReloCheck.Views;

public partial class RoomDetailss : ContentPage
{
	public RoomDetailss()
	{
		InitializeComponent();

    }

    private async void OnButtonClick(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new AddRoom());

    }

    private void OnReloadClick(object sender, EventArgs ex)
    {
        string connstring = @"server=LAPTOP-UPC09RTU;userid=default;password=default;database=MoverSynq ";

        MySqlConnection conn = null;

        try
        {
            conn = new MySqlConnection(connstring);
            conn.Open();

            string list = "SELECT * FROM Room";
            MySqlDataAdapter da = new MySqlDataAdapter(list, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Room");
            DataTable dt = ds.Tables["Room"];

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write("\n");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.ToString());
        }
        finally
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }

}


