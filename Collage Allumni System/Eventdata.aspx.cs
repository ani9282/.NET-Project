using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Eventdata : System.Web.UI.Page
{
    static string choice="";
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string event_name = DropDownList1.Text;
        if(RadioButton1.Checked)
        {
            choice = RadioButton1.Text;
            RadioButton2.Checked = false;
        }
        else
        {
            choice = RadioButton2.Text;
            RadioButton1.Checked = false;
        }


        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Eventmaster where Eventname='"+event_name+"' and Event='"+choice+"'";

            int i =Convert.ToInt32( cmd.ExecuteScalar().ToString());
            Label1.Visible = true;
            Label1.ForeColor = System.Drawing.Color.White;
            Label1.Font.Bold = true;
   
            Label1.Text = i.ToString();

        }
        catch
        {

            throw;
        }
    }
}