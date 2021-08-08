using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pathalogyReg : System.Web.UI.Page
{
    string email_id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label20.Visible = false;
        if (Session["adminusername"] == null)
        {
            Response.Redirect("~/index.html");
        }
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlDataAdapter sa = new MySqlDataAdapter("select * from pathalogyReg", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            email_id = dt.Rows[0][4].ToString();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string em = Request.Form["email"];
        if (em==email_id)
        {
            Label20.Visible = true;
            Label20.Font.Bold = true;
            Label20.Text = "email already Registered";
        }

        else{
            string name = Request.Form["username"];
            string add = Request.Form["add"];
            string mob = Request.Form["mob"];
            string email = em;
            string pwd = Request.Form["password"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into pathalogyReg (Name,Address,Mobile,Email,Passowrd)values ('" + name + "','" + add + "','" + mob + "','" + email + "','" + pwd + "')";
                cmd.Parameters.AddWithValue("Name", name);
                cmd.Parameters.AddWithValue("Address", add);
                cmd.Parameters.AddWithValue("Mobile", mob);
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("Passowrd", pwd);
                cmd.ExecuteNonQuery();
                Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Successful')</script>");

            }
            catch
            {

                throw;
            }
        }

    }
}