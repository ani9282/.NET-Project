using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard1 : System.Web.UI.Page
{
    public static int RollNo;
    public static int Other = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        RollNo = Convert.ToInt32(Session["RollNo"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}