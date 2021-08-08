using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_create_user : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void RadioButton1_CheckedChanged(object sender, System.EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String name = Request.Form["FName"];
        String Lname = Request.Form["LName"];
        String Email = Request.Form["Email"];
        String Password = Request.Form["Password"];
        String Password1 = Request.Form["password1"];
        String s = Request.Form["gender"];
        String s1= Request.Form["gender1"];
        String s2 = Request.Form["gender2"];

        String s3 = Request.Form["gender3"];
        String s4 = Request.Form["gender4"];
        String s5 = Request.Form["gender5"];
        String s6 = Request.Form["gender6"];
        String s7 = Request.Form["gender7"];
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
       

        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Insert Into tbl_adminuser values('" + Email + "','" + Password + "','" + Password1 + "','"+name+"','"+Lname+"','"+s+"','"+s1+"','"+s2+"','"+s3+"','"+s5+"','"+s6+"','"+s7+"')";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();

      ModalPopupExtender1.Show();

    }
}