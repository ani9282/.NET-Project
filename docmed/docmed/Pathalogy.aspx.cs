using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pathoLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string pName = null;
        string name = txtUsername.Text;
        //string name = Request.Form["email"];
        string pass =txtpassword.Text;
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlDataAdapter sa = new MySqlDataAdapter("select * from pathalogyReg where Email='" + name + "' AND Passowrd='"+pass+"'", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            pName = dt.Rows[0][1].ToString();
            Session["pName"] = name;
            Response.Redirect("~/PathalogyDashboard.aspx");
        }
        else
        {
            Label1.Visible = true;
            Label1.Font.Bold = true;
            Label1.Text = "Please Re-Enter Credential";
        }

     //   Response.Redirect("~/Dash/PathalogyDashboard.html"); ;
        
    }
}