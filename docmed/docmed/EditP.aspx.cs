using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;

public partial class EditP : System.Web.UI.Page
{
    static string gender;
    static string insurance;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminusername"] == null)
        {
            Response.Redirect("~/index.html");
        }
        RadioButton1.Enabled = false;
        RadioButton2.Enabled = false;
    }

  
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        string date = Request.Form["date"];
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlDataAdapter sa = new MySqlDataAdapter("Select * from Petiant where rfidNo=" + TextBox1.Text + "", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {
           
            TextBox2.Text = dt.Rows[0][1].ToString();
            TextBox3.Text = dt.Rows[0][2].ToString();
            TextBox10.Text = dt.Rows[0][3].ToString();
            TextBox11.Text = dt.Rows[0][4].ToString();
            TextBox15.Text= dt.Rows[0][5].ToString();
           TextBox5.Text = dt.Rows[0][6].ToString();
           TextBox6.Text = dt.Rows[0][7].ToString();
            DropDownList1.Text = dt.Rows[0][8].ToString();
         
            gender = dt.Rows[0][9].ToString();
            insurance= dt.Rows[0][10].ToString();





            if (gender.Equals("Male"))
            {
                RadioButton1.Checked = true;
                RadioButton2.Checked = false;
            }
            else
            {
                RadioButton2.Checked = true;
                RadioButton1.Checked = false;
            }

            if (insurance.Equals("Yes"))
            {
                CheckBox3.Checked = true;
                CheckBox4.Checked = false;
            }
            else
            {
                CheckBox4.Checked = true;
                CheckBox3.Checked = false;
            }
        }
        else
        {

        }


    }



    protected void Button2_Click(object sender, EventArgs e)
    {
       // string date = Request.Form["date"];
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        try
        { 
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = "Update Petiant set name='" + TextBox3.Text + "',email='" + TextBox10.Text + "',password='" + TextBox11.Text + "',dob='" + TextBox15.Text + "',mobile='" + TextBox5.Text + "',address='"+TextBox6.Text+"',bg='" + DropDownList1.Text + "',gender='"+gender+"',insurance='"+insurance+"' Where rfidNo='" + TextBox1.Text + "' ";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");
        }
        catch
        {
            throw;
        }
    }
}