using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



public partial class EditStudentProfile : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)

        {
            string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);


            con.Open();
            String username = Session["Username"].ToString();
            String password = Session["Password"].ToString();
            SqlDataAdapter da = new SqlDataAdapter("Select * from studentmaster where Username='" + username + "' and password='" + password + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtstudentid.Text = dt.Rows[0][0].ToString();
                txtstudentname.Text = dt.Rows[0][1].ToString();
                txtmobno.Text = dt.Rows[0][2].ToString();
                TextBox1.Text = dt.Rows[0][3].ToString();
                txtbrname.Text = dt.Rows[0][4].ToString();
                txtusername.Text = dt.Rows[0][5].ToString();
                txtpassword.Text = dt.Rows[0][6].ToString();
            }
        }

    }




    protected void btnsave_Click(object sender, EventArgs e)
    {

    }

    protected void btnupdaqte_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update studentmaster set studentname='" + txtstudentname.Text + "',mobileno='" + txtmobno.Text + "',emailid='" + TextBox1.Text + "',branchname='" + txtbrname.Text + "',username='" + txtusername.Text + "',password='" + txtpassword.Text + "',class='" + DropDownList1.Text + "' where studentid='" + txtstudentid.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");
    }

    protected void btngene_Click(object sender, EventArgs e)
    {

    }
}





    