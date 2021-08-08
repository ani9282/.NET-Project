using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;

public partial class PatientRaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminusername"] == null)
        {
            Response.Redirect("~/index.html");
        }
    }

    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {
            }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            string date = Request.Form["date"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
                cmd.CommandText = "insert into Petiant (rfidNo,name,height,address,BloodGroup,Allergies,Date)values (@rfidNo,@name,@height,@address,@BloodGroup,@Allergies,@date)";
                cmd.Parameters.AddWithValue("rfidNo", TextBox1.Text);
                cmd.Parameters.AddWithValue("@name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@height", TextBox4.Text);
                cmd.Parameters.AddWithValue("@address", TextBox5.Text);
                cmd.Parameters.AddWithValue("@BloodGroup", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@Allergies",CheckBox1.Text);
                cmd.Parameters.AddWithValue("@date",date);
            cmd.ExecuteNonQuery();
                Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");
                clear();
            

        }
        else
        {
            string date = Request.Form["date"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Petiant (rfidNo,name,height,address,BloodGroup,Allergies,Date)values (@rfidNo,@name,@age,@height,@address,@BloodGroup,@Allergies,@Directives,@date)";
            cmd.Parameters.AddWithValue("rfidNo", TextBox1.Text);
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
          
            cmd.Parameters.AddWithValue("@height", TextBox4.Text);
            cmd.Parameters.AddWithValue("@address", TextBox5.Text);
            cmd.Parameters.AddWithValue("@BloodGroup", DropDownList1.Text);
            cmd.Parameters.AddWithValue("@Allergies",CheckBox2.Text);
          
            cmd.Parameters.AddWithValue("@date",date);
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");
            clear();


        }




    }
    void clear()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
       
        TextBox4.Text = "";
        TextBox5.Text = "";
        DropDownList1.Text = "";
       // CheckBox.Text = "";
       
     }
   
}