using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserDashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String data = Request.QueryString["email"];
        String data1 = Request.QueryString["password"];

        Session["Email"] = data;
        Session["Password"] = data1;

        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        SqlDataAdapter da = new SqlDataAdapter("Select * from Man_Account where email='" + data + "' AND password='" + data1 + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            String name = dt.Rows[0][1].ToString();
            Label1.Text = "Hello  " + name;


            Label2.Text = name;
            Label3.Text = data;

            SqlDataAdapter eda = new SqlDataAdapter("Select * from Man_EmailSub where Email='" + data + "' ", con);
            DataTable edt = new DataTable();
            eda.Fill(edt);
            if (edt.Rows.Count > 0)
            {

                Label4.Text = "You are Currently Subscribed to Our News Letter";

            }
            else
            {
                Label4.Text = "You are Currently Not Subscribed to Our News Letter";

            }

        }
    }
}