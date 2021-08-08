using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Student_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        string MNo = Request.Form["MobileNumber"];
        string Password = Request.Form["password"];
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tbl_Student_Register where Mobile_No = '" + MNo + "' And Password = " + Password + "",con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        if(dt.Rows.Count > 0)
        {
            Response.Write("<Script LANGUAGE= 'JavaScript' > alert ('Login Successfully')</script>");
        }
        else
        {
            Response.Write("<Script LANGUAGE= 'JavaScript' > alert ('Invalid Mobile Number And Password')</script>");
        }
       
    }
}