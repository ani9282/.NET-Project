using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DoctorReg : System.Web.UI.Page
{

    string email_id;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        Label20.Visible =false;
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        if (!IsPostBack)
        {
            if (Session["adminusername"] == null)
            {
                Response.Redirect("~/index.html");
            }
           
            MySqlCommand cmd = new MySqlCommand("select Name from typemaster");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            ddlCustomers.DataSource = cmd.ExecuteReader();
            ddlCustomers.DataTextField = "Name";
            ddlCustomers.DataBind();
            con.Close();

            ddlCustomers.Items.Insert(0, new ListItem("--Select Specilization--", "0"));     
        }
        
        MySqlDataAdapter sa = new MySqlDataAdapter("select * from DoctorReg", con);
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


        else
        {
            string name = Request.Form["username"];
            string add = Request.Form["add"];
            string mob = Request.Form["mob"];
            string email = em;
            string pwd = Request.Form["password"];
            string type = ddlCustomers.SelectedItem.ToString();
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into DoctorReg (Name,Address,Mobile,Email,Passowrd,Doctor_type)values ('" + name + "','" + add + "','" + mob + "','" + email + "','" + pwd + "','" + type + "')";
                cmd.Parameters.AddWithValue("Name", name);
                cmd.Parameters.AddWithValue("Address", add);
                cmd.Parameters.AddWithValue("Mobile", mob);
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("Passowrd", pwd);
                cmd.Parameters.AddWithValue("Doctor_type", ddlCustomers.Text);
                cmd.ExecuteNonQuery();
                string mobile = mob;
                string Username = "rahulpawar";
                string pass = "Rahul@123";
                string APIKey = "ROYALS";
                WebClient client = new WebClient();
                String Message = "Thank You For registration For Smart Medical System \n Username '" + email + "' Password '" + pwd + "' ";
                string baseurl = "http://www.smssigma.com/API/WebSMS/Http/v1.0a/index.php?username=" + Username + "&password=" + pass + "&sender=" + APIKey + "&to=" + mobile + "&message='" + Message + "'&reqid=1&format={json|text}&route_id=7&msgtype=unicode";
                Stream data = client.OpenRead(baseurl);

                StreamReader reader = new StreamReader(data);
                string ResponseID = reader.ReadToEnd();
                data.Close();
                reader.Close();

                Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Successful')</script>");

            }


            catch
            {

                throw;
            }

        }

    }

}

