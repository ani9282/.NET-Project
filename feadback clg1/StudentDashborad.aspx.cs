using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentDashborad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {


              Label2.Text = Session["name"].ToString();
            Label3.Text = Session["class"].ToString();
            Label5.Text = Session["branch"].ToString();
        }

    }
}