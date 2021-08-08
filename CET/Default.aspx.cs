using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
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

        SqlDataAdapter da = new SqlDataAdapter("Select * from CET_tbl_Student_Register where Mobile_No='" + username + "' and Password='" + password + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Session["RollNo"] = Convert.ToInt32(dt.Rows[0][0]);
            Session["student"] = username;
            Response.Redirect("Dashboard1.aspx");

        }
        else
        {
            ModalPopupExtender1.Show();
        }


    }
}

