using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Net.Mail;
using System.Net;

public partial class teachermaster : System.Web.UI.Page
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
        cmd.CommandText = "Select MAX(teacherid) from teachermaster";
        cmd.Connection = con;
        int i = 0;

        try
        {
            i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            i++;
            txtteacherid.Text = i.ToString();
        }
        catch (Exception ex)

        {
            txtteacherid.Text = "1";

        }

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);


        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into teachermaster(teacherid,teachername,mobileno,emailid,branchname,username,password) values('" + txtteacherid.Text + "','" + txtteachername.Text + "','" + txtmobno.Text + "','" + txtemailid.Text + "','" + txtbrname.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')", con);
        cmd.Connection = con;
        cmd.ExecuteNonQuery();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");
        GridView1.DataBind();

        using (MailMessage mm = new MailMessage("enoticegov@gmail.com", txtemailid.Text))
        {
            mm.Subject = "This Mail Was Shri.Jaywantrao Bhasale Polytechnic Collage,K.M.Gad";
            mm.Body = "Your User Name-" + txtusername.Text +
                "Your password is-" + txtpassword.Text ;

            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            System.Net.NetworkCredential NetworkCred = new NetworkCredential("enoticegov@gmail.com", "enotice123");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mm);
            ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
        }


        clear();

    }
    private void clear()
    {
        txtteacherid.Text = " ";
        txtteachername.Text = " ";
        txtmobno.Text = " ";
        txtemailid.Text = " ";
        //txtbrname.Text = " ";
        txtusername.Text = " ";
        txtpassword.Text = " ";



    }




    protected void btnupdaqte_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update teachermaster set teachername='" + txtteachername.Text + "',mobileno='" + txtmobno.Text + "',emailid='" + txtemailid.Text + "',branchname='" + txtbrname.Text + "',username='" + txtusername.Text + "',password='" + txtpassword.Text + "' where teacherid='" + txtteacherid.Text + "'";
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
        cmd.CommandText = "Delete from teachermaster where teacherid='" + txtteacherid.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        clear();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Delete Successful')</script>");
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtteacherid.Text = GridView1.SelectedRow.Cells[1].Text;
        txtteachername.Text = GridView1.SelectedRow.Cells[2].Text;
        txtmobno.Text = GridView1.SelectedRow.Cells[3].Text;
        txtemailid.Text = GridView1.SelectedRow.Cells[4].Text;
        txtbrname.Text = GridView1.SelectedRow.Cells[5].Text;
        txtusername.Text = GridView1.SelectedRow.Cells[6].Text;
        txtpassword.Text = GridView1.SelectedRow.Cells[7].Text;
    }

    protected void btngene_Click(object sender, EventArgs e)
    {
        Random generator = new Random();
        String r = generator.Next(0, 999999).ToString("D6");
        txtpassword.Text = r;
    }

    protected void btngene_Click1(object sender, EventArgs e)
    {
        Random generator = new Random();
        String r = generator.Next(0, 999999).ToString("D6");
        txtpassword.Text = r;

    }

    protected void txtemailid_TextChanged(object sender, EventArgs e)
    {
       
    }
}
