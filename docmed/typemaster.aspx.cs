using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class typemaster : System.Web.UI.Page
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
        string name = TextBox2.Text.ToString();
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();
        try
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into typemaster (Name) values ('" + name + "')";
            cmd.Parameters.AddWithValue("Name", name);
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Successful')</script>");

        }
        catch
        {

            throw;
        }
    }
    }