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
using DevExpress.XtraReports.Design;

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
    string MyConnectionString = @"server=LAPTOP-UPC09RTU;userid=default;password=default;database=MoverSynq ";

    private void OnReloadClick(object sender, EventArgs ex)
    {
        //try
        //{
        //    string Query = "SELECT * FROM ROOM.MoverSynq;";
        //    MySqlConnection MyConn = new MySqlConnection(MyConnectionString);
        //    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);

        //    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        //    MyAdapter.SelectCommand = MyCommand;
        //    DataTable dTable = new DataTable();
        //    MyAdapter.Fill(dTable);
        //} catch (Exception ez)
        //{
        //    throw;
        //}

        
    }

}


//string MyConnectionString = @"server=LAPTOP-UPC09RTU;userid=default;password=default;database=MoverSynq ";

//MySqlConnection conn = null;

//        try
//        {
//            conn = new MySqlConnection(MyConnectionString);
//conn.Open();

//            string list = "SELECT * FROM Room";
//MySqlDataAdapter da = new MySqlDataAdapter(list, conn);
//DataSet ds = new DataSet();
//da.Fill(ds, "Room");
//            DataTable dt = ds.Tables["Room"];

//            foreach (DataRow row in dt.Rows)
//            {
//                foreach (DataColumn col in dt.Columns)
//                {
//                    Console.Write("\n");
//                }
//            }
//        }
//        catch (Exception e)
//        {
//    Console.WriteLine("Error: {0}", e.ToString());
//}
//        finally
//        {
//    if (conn != null)
//    {
//        conn.Close();
//    }
//}