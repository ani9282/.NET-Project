using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class SemisterMaster : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
    private SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void BindGrid()
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        using (SqlConnection con = new SqlConnection(conn))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT SemesterId,SemesterName FROM SemesterMaster"))
            {
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    GridView1.DataSourceID = "";
                    GridView1.DataSource = sdr;
                    GridView1.DataBind();
                }
                con.Close();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);


        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into SemesterMaster(SemesterId,SemesterName) values('" + TextBox1.Text + "','" + DropDownList1.Text + "')", con);
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");
        //GridView1.DataBind();
        BindGrid();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update SemesterMaster set SemesterName='" + DropDownList1.Text + "' where semesterId='" + TextBox1.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");
        BindGrid();

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        TextBox1.Text = GridView1.SelectedRow.Cells[0].Text;
        DropDownList1.Text = GridView1.SelectedRow.Cells[1].Text;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }
}