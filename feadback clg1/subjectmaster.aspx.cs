using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class subjectmaster : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
        }
    }

    protected void btnnew_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);




        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select (subject code) from subjectMaster1";
        cmd.Connection = con;
        int i = 0;




    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);


        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into subjectMaster1(subjectcode,subjectname,Class,Branch,SemesterName) values('" + txtsubcode.Text + "','" + txtsubname.Text + "','"+ DropDownList1.Text+"','"+DropDownList2.Text+"','"+DropDownList3.Text+"')", con);
        cmd.Connection = con;
        cmd.ExecuteNonQuery();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");
        GridView1.DataBind();



        clear();
    }
    private void clear()
    {
        txtsubcode.Text = " ";
        txtsubname.Text = " ";
       

    }





    protected void btnupdaqte_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update subjectMaster1 set subjectname='" + txtsubname.Text + "' where subjectcode='" + txtsubcode.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();


        GridView1.DataBind();


        clear();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");

    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Delete from subjectMaster1 where subjectcode='" + txtsubcode.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        clear();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Delete Successful')</script>");
        GridView1.DataBind();

    }

    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        this.BindGrid();
    }

    private void BindGrid()
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        using (SqlConnection con = new SqlConnection(conn))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT subjectcode,subjectname,Class,Branch,SemesterName FROM subjectMaster1"))
            {
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    GridView1.DataSourceID = null;
                    GridView1.DataSource = sdr;
                    GridView1.DataBind();
                }
                con.Close();
            }
        }
        throw new NotImplementedException();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtsubcode.Text = GridView1.SelectedRow.Cells[1].Text;
        txtsubname.Text = GridView1.SelectedRow.Cells[2].Text;
        DropDownList1.Text = GridView1.SelectedRow.Cells[3].Text;
        DropDownList2.Text = GridView1.SelectedRow.Cells[4].Text;
        DropDownList3.Text = GridView1.SelectedRow.Cells[5].Text;




    }
}

   

    


