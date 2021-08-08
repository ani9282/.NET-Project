using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;
public partial class Eventmaster1 : System.Web.UI.Page
{
    String data;
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=collage Alumni;Integrated Security=True");
   // SqlCommand com;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        // SqlCommand cmd = new SqlCommand();
        string Event = string.Empty;
      
        
            SqlCommand cmd = new SqlCommand("insert into Eventmaster1 (Eventid,Eventname,date)values('" + txtid.Text + "','" + DropDownList1.Text + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "')", con);
        
        con.Open();
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        GridView1.DataBind();
        // clear();
        con.Close();
        Response.Redirect("Dashbord1.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select MAX(Eventid) from Eventmaster1";
        cmd.Connection = con;
        int i = 0;
        try
        {
            i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            txtid.Text = i.ToString();
        }
        catch (Exception ex)
        {

            txtid.Text = "1";

            cmd.ExecuteNonQuery();


        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        //SqlCommand cmd = new SqlCommand();
        SqlCommand cmd = new SqlCommand("Delete from Eventmaster1 where Eventid ='" + txtid.Text + "'", con);
        // cmd.CommandText = "Delete from staffregistration where teacherid ='" + txtid.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();
        cleardata();
        GridView1.DataBind();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Delete Successful')</script>");
    }
    private void cleardata()
    {
        txtid.Text = " ";
        DropDownList1.Text = " ";



    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update Eventmaster1 set Eventid='" + txtid.Text + "',Eventname='" + DropDownList1.Text + "',date='" + DateTime.Now.ToString("MM/dd/yyyy") + "' where Eventid='" + txtid.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        GridView1.DataBind();


        clearall();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");


    }
    private void clearall()
    {
        txtid.Text = " ";
        DropDownList1.Text = " ";

    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        txtid.Text = GridView1.SelectedRow.Cells[1].Text;
       DropDownList1.Text = GridView1.SelectedRow.Cells[2].Text;
    }

    protected void date_TextChanged(object sender, EventArgs e)
    {

    }
}

