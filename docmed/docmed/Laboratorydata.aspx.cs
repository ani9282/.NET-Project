using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Laboratorydata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["pName"] == null)
        {
            Response.Redirect("~/index.html");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (FileUpload1.HasFile)
        {

            FileUpload1.SaveAs(Server.MapPath("Pathalogy_images//" + FileUpload1.FileName));
            Label1.Text = "Image Uploaded Successfully....";
            Label1.ForeColor = System.Drawing.Color.ForestGreen;
        }
        else
        {
            Label1.Text = "Please Select your file";
            Label1.ForeColor = System.Drawing.Color.Red;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
    }
}