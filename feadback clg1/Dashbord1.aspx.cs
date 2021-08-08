using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashbord1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label2.Text = Session["name"].ToString();  /// Name of Staff

      
        Label4.Text = Session["Branch"].ToString();

    }
}