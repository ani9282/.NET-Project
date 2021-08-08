using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_CouponList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (!IsPostBack)
        {
            getData();
        }*/
    }

    public void DropDownList1_SelectedIndexChanged(object sender,EventArgs e)
    {

    }
    /*public void getData()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);




        con.Open();

        SqlDataAdapter da = new SqlDataAdapter("select CouponCode,CouponTitle,Quantiy,Status from tblCouponManagement", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        grdView.DataSource = dt;
        grdView.DataBind();
    }*/

    protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {


        /* This condition work when click on delete button */
        /*if (e.CommandName == "lnkbtnDelete")
        {
            int id = int.Parse(e.CommandArgument.ToString());
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);





            SqlCommand cmd = new SqlCommand("delete from tblCouponManagement where CouponCode='" + id + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            getData(); /* Reload gridview */
        //}
    }
}