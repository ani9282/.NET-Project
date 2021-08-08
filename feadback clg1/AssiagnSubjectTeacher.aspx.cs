using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class AssiagnSubjectTeacher : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
    private SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        int id = 1;
        SqlDataAdapter da = new SqlDataAdapter("select * from SemesterMaster where SemesterId ='" + id + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            TextBox1.Text = dt.Rows[0][1].ToString();
        }
        if (id == 0)
        {


            id++;
        }

    }
    private void BindGrid()
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        using (SqlConnection con = new SqlConnection(conn))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Branch,Teachername,Class,SemesterName FROM TeacherAssgSub"))
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);

        String str = DropDownList7.SelectedItem.ToString();
        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into TeacherAssgSub(Branch,Teachername,Class,SemesterName,subjectName) values('" + DropDownList2.Text + "','" + DropDownList3.Text + "','"+DropDownList6.Text+"','"+TextBox1.Text+"','"+str+"')", con);
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");
        GridView1.DataBind();

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update TeacherAssgSub set Branch='" + DropDownList2.Text + "' where Teachername='" + DropDownList3.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList3.Text = GridView1.SelectedRow.Cells[2].Text;
        DropDownList2.Text = GridView1.SelectedRow.Cells[1].Text;
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //DropDownList3.Text = GridView1.SelectedRow.Cells[2].Text;
        String str = DropDownList2.Text;
        //SqlCommand cmd = new SqlCommand("select * from TeacherAssgSub", con);
        //SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //DataTable dt = new DataTable();
        //sda.Fill(dt);
        //DropDownList3.DataSource = dt;
        //DropDownList3.DataBind();


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlDataAdapter dd = new SqlDataAdapter("select * from subjectMaster1 where Branch='" + DropDownList2.Text + "' AND class='" + DropDownList6.Text + "' AND SemesterName='" + TextBox1.Text + "' ", con);
        DataTable tt = new DataTable();
        dd.Fill(tt);
        DropDownList7.DataSource = tt;

        DropDownList7.DataTextField = "Subjectname";
        DropDownList7.DataValueField = "Subjectcode";
        DropDownList7.DataBind();
    }
}