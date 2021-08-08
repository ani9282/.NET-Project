using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrentDash : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

         Label2.Text = Session["name"].ToString();
        Label3.Text = Session["class"].ToString();
       Label5.Text = Session["branch"].ToString();



    }
}