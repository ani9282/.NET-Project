using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

//private object txtbrid;

//private object txtbrid;

public partial class dash : System.Web.UI.Page
{
  //  SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
    private SqlCommand cmd;

    public object MessageBoxButtons { get; private set; }
    public object MessageBoxIcon { get; private set; }
    public object MessageBox { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
          //  this.BindGrid();
        }
    }
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
       // this.BindGrid();
    }
    private void BindGrid()
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        using (SqlConnection con = new SqlConnection(conn))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT branchid,branchname FROM branchmaster"))
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
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {


        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);


            con.Open();
        SqlCommand cmd = new SqlCommand("Insert into branchmaster(branchid,branchname) values('" + txtbrid.Text + "','" + txtbrname.Text + "')", con);
        cmd.Connection = con;
        cmd.ExecuteNonQuery();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");
        GridView1.DataBind();



        clear();
    }
    private void clear()
    {
         txtbrid.Text = " ";
        txtbrname.Text = " ";



    }








    //private void ExecuteInsert(string text1, string text2)
    //{
    //    throw new NotImplementedException();
    //}

    protected void Button1_Click(object sender, EventArgs e)
{

}

protected void btnnew_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);




        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select MAX(branchid) from branchmaster";
        cmd.Connection = con;
        int i = 0;

        try
        {
            i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            i++;
            txtbrid.Text = i.ToString();
        }
        catch (Exception ex)

        {
            txtbrid.Text = "1";

        }


    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtbrid.Text = GridView1.SelectedRow.Cells[1].Text;
        txtbrname.Text = GridView1.SelectedRow.Cells[2].Text;
    }

    protected void btnupdaqte_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update branchmaster set branchname='" + txtbrname.Text + "' where branchid='" + txtbrid.Text + "'";
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
        cmd.CommandText = "Delete from branchmaster where branchid='" + txtbrid.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        clear();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Delete Successful')</script>");
        GridView1.DataBind();


    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        this.BindGrid();
    }

    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        this.BindGrid();
    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        txtbrid.Text = GridView1.SelectedRow.Cells[1].Text;
        txtbrname.Text = GridView1.SelectedRow.Cells[2].Text;
    }
}





