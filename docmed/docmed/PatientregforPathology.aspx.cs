using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PatientregforPathology : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["pName"] == null)
        {
            Response.Redirect("~/index.html");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {


        string dob = Request.Form["date"];
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();

        cmd = con.CreateCommand();
        cmd.CommandText = "insert into Petiant (rfidNo,name,email,password,dob,mobile,address,bg,gender,insurance)values (@rfidNo,@name,@email,@password,@dob,@mobile,@address,@bg,@gender,@insurance)";
        cmd.Parameters.AddWithValue("rfidNo", TextBox2.Text);
        cmd.Parameters.AddWithValue("@name", TextBox3.Text);
        cmd.Parameters.AddWithValue("@email", TextBox10.Text);
        cmd.Parameters.AddWithValue("@password", TextBox11.Text);
        cmd.Parameters.AddWithValue("@dob", dob);
        cmd.Parameters.AddWithValue("@mobile", TextBox5.Text);
        cmd.Parameters.AddWithValue("@address", TextBox6.Text);
        cmd.Parameters.AddWithValue("@bg", DropDownList1.Text);



        if (RadioButton1.Checked)
        {
            cmd.Parameters.AddWithValue("@gender", RadioButton1.Text);
        }
        else
        {
            cmd.Parameters.AddWithValue("@gender", RadioButton2.Text);
        }

        if (CheckBox3.Checked)
        {
            cmd.Parameters.AddWithValue("@insurance", CheckBox3.Text);
        }
        else
        {
            cmd.Parameters.AddWithValue("@insurance", CheckBox4.Text);
        }
        cmd.ExecuteNonQuery();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");




    }
}