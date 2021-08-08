using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class endlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlDataAdapter da2 = new SqlDataAdapter("Select * from tblFiles1", con);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);
        int length2 = dt2.Rows.Count;
        for (int i = 0; i <= length2; i++)
        {
            if (i == 0)
            {
                Label42.Text = dt2.Rows[i][4].ToString();


            }

            if (i == 1)
            {
                Label43.Text = dt2.Rows[i][4].ToString();


            }

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String email = Request.Form["email"];
        String password = Request.Form["password"];

        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        SqlDataAdapter da = new SqlDataAdapter("Select * from Man_Account where email='" + email + "' AND password='" + password + "'",con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            Response.Redirect("~/UserDashboard.aspx?Email=" + email + "&password=" + password);
        }
        else
        {
            ModalPopupExtender1.Show();

        }
       
    }
}