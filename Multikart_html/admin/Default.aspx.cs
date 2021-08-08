using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String username = Request.Form["username"];
        String password = Request.Form["password"];
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);




        con.Open();

        SqlDataAdapter da = new SqlDataAdapter("Select * from krs_loginadmin where username='" + username + "' and password='" + password + "'",con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            Response.Redirect("Dashboard.aspx");

        }
        else
        {
            ModalPopupExtender1.Show();
        }


    }
}