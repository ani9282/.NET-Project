using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class Medicine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminusername"] == null)
        {
            Response.Redirect("~/index.html");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();
        try
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into MedicineInfo (Id,medicineName)values (@Id,@medicineName)";
            cmd.Parameters.AddWithValue("@Id", TextBox3.Text);
            cmd.Parameters.AddWithValue("@medicineName", TextBox2.Text);
           
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");
           clear();
        }
        catch
        {

            throw;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        try
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Update MedicineInfo set medicineName='" + TextBox2.Text + "'Where Id='" + TextBox3.Text + "' ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");
            clear();
        }
        catch
        {
            throw;
        }
    }
     void clear()
    {
        TextBox2.Text = "";
        TextBox3.Text = "";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        try
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Delete  from  MedicineInfo Where Id='" + TextBox3.Text + "' ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Delete Successful')</script>");
            clear();
        }
        catch
        {
            throw;
        }
    }
}