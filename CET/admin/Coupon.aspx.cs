using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Coupon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);



        con.Open();
        string QueryString = "select * from tblFiles1";

        SqlDataAdapter myCommand = new SqlDataAdapter(QueryString, con);
        DataSet ds = new DataSet();
        myCommand.Fill(ds, "tblFiles1");

        exampleFormControlSelect3.DataSource = ds;
        exampleFormControlSelect3.DataTextField = "Cat_Name";
        exampleFormControlSelect3.DataValueField = "Cat_Name";
        exampleFormControlSelect3.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
        con.Open();
        String title = validationCustom0.Value;
        String couponcode = validationCustom1.Value;
        String sdate = Request.Form["stdate"];
        String edate = Request.Form["eddate"];
        String checkbox=Request.Form["chkbox"];
        String Quantity = Request.Form["Quantity"];
        String Type = typ.Value.ToString();
        String enable = Request.Form["en"];
        String product = validationCustom3.Value.ToString();
        String Cat_Name = exampleFormControlSelect3.Value.ToString();
        String minspend = Request.Form["minspend"];
        String maxspend = Request.Form["maxspend"];
        String perlimit = Request.Form["perlimit"];
        String percustiomer = Request.Form["percustomer"];
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Insert Into tblCouponManagement values('" + title + "','" + couponcode + "','" + sdate + "','" + edate+ "','"+checkbox+"','"+Quantity+"','"+Type+"','"+enable+"','"+product+"','"+Cat_Name+"','"+minspend+"','"+maxspend+"','"+perlimit+"','"+percustiomer+"')";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
       ModalPopupExtender1.Show();
    }
}