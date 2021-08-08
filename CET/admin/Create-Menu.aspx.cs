using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Create_Menu : System.Web.UI.Page
{
    private static TimeZoneInfo India_Standard_Time = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String menuname = validationCustom0.Value;
        if (CheckBox1.Checked)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            DateTime dateTime_Indian = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, India_Standard_Time);
            DateTime today = DateTime.Now;
           DateTime dt= dateTime_Indian;

            con.Open();
            String Flag = "true";
            
            String s=Request.Form["POD"];
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into Menus values('" + menuname + "','" + Flag + "','"+dt+"','"+s+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            ModalPopupExtender1.Show();



        }
        else
        {

            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

       
            DateTime dateTime_Indian = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, India_Standard_Time);
            DateTime today = DateTime.Now;
            DateTime dt = dateTime_Indian;

            con.Open();
            String Flag = "False";
            String s = Request.Form["POD"];

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into Menus values('" + menuname + "','" + Flag + "','"+dt+"','"+s+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            ModalPopupExtender1.Show();

        }


    }
}