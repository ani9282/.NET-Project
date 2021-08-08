using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        HiddenField1.Value =Convert.ToString( 28.577921000000000000); //Get from database
        HiddenField2.Value =Convert.ToString( 77.318060100000020000);//
    }
}