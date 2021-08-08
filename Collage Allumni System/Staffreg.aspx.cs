using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;

public partial class Staffreg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=collage Alumni;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);


        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into staffregistration(teacherid,teachername,mobileno,emailid,branchname,photo) values('" + txtteacherid.Text + "','" + txtteachername.Text + "','" + txtmobno.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + FileUpload1 + "')", con);
        cmd.Connection = con;
        cmd.ExecuteNonQuery();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");
        GridView1.DataBind();

        //using (MailMessage mm = new MailMessage("enoticegov@gmail.com", txtemailid.Text))
        //{
        //    mm.Subject = "This Mail Was KRP Collage,islampur";
        //    mm.Body = "Your User Name-" + txtUsername.Text +
        //        "Your password is-" + txtpassword.Text;

        //    mm.IsBodyHtml = false;
        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.EnableSsl = true;
        //    System.Net.NetworkCredential NetworkCred = new NetworkCredential("enoticegov@gmail.com", "enotice123");
        //    smtp.UseDefaultCredentials = true;
        //    smtp.Credentials = NetworkCred;
        //    smtp.Port = 587;
        //    smtp.Send(mm);
        //    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
        //}


        clear();

    }
    private void clear()
    {
        txtteacherid.Text = " ";
        txtteachername.Text = " ";
        txtmobno.Text = " ";
        TextBox1.Text = " ";
        TextBox2.Text = " ";
        //txtusername.Text = " ";
        //txtpassword.Text = " ";



    }




    protected void btnnew_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);




        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select MAX(id) from staffregistration";
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


    protected void btnupdaqte_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update staffregistration set teachername='" + txtteachername.Text + "',mobileno='" + txtmobno.Text + "',emailid='" + TextBox1.Text + "',branchname='" + TextBox2.Text + "' where teacherid='" + txtteacherid.Text + "'";
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
        cmd.CommandText = "Delete from staffregistration where teacherid='" + txtteacherid.Text + "'";
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
        TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
         TextBox2.Text = GridView1.SelectedRow.Cells[5].Text;
    }
}

