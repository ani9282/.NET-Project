using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;

    }

    protected void Button1_Click(object sender, EventArgs e)


    {
        string name = txtUsername.Text;
        string pass = txtpassword.Text;
        if (name == "admin@gmail.com" && pass == "admin")
        {
            Session["adminusername"] = "admin@gmail.com";
            Response.Redirect("~/DashBoard.aspx"); 
        }

        else
        {
            Label1.Visible = true;
            Label1.Font.Bold = true;
            Label1.Text = "Please Re-Enter Credential";
        }
    }
}