using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PatientReg : System.Web.UI.Page
{
    static string rfid, email;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["adminusername"] == null)
        {
            Response.Redirect("~/index.html");
        }
        Label21.Visible = false;
        Label20.Visible = false;
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlDataAdapter sa = new MySqlDataAdapter("select * from Petiant", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            rfid = dt.Rows[0][1].ToString();                 
            email = dt.Rows[0][3].ToString();

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {


        string dob = Request.Form["date"];
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();

        if (TextBox2.Text == rfid)
        {
            Label21.Visible = true;
            Label21.Font.Bold = true;
            Label21.Text = "RFid already Registered";
        }

        else if (TextBox10.Text == email)
        {
            Label20.Visible = true;
            Label20.Font.Bold = true;
            Label20.Text = "email already Registered";
        }

        if (TextBox11.Text == "")
        {
            Label20.Visible = true;
            Label20.Font.Bold = true;
            Label20.Text = "Please Enter Password";
        }

        else
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Petiant (rfidNo,name,email,password,dob,mobile,address,bg,gender,insurance)values (@rfidNo,@name,@email,@password,@dob,@mobile,@address,@bg,@gender,@insurance)";
            cmd.Parameters.AddWithValue("@rfidNo", TextBox2.Text);
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
}