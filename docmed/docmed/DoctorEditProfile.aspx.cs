using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DoctorEditProfileaspx : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["dName"] == null)
            {
                Response.Redirect("~/index.html");
            }
                string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select Name from typemaster");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            ddlCustomers.DataSource = cmd.ExecuteReader();
            ddlCustomers.DataTextField = "Name";
            ddlCustomers.DataBind();
            con.Close();

            ddlCustomers.Items.Insert(0, new ListItem("--Select Specilization--", "0"));

            String dName = Session["dName"].ToString();
            MySqlDataAdapter sa = new MySqlDataAdapter("select * from DoctorReg where Name='" + Session["dName"] + "'", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                TextBox1.Text = dt.Rows[0][1].ToString();
                TextBox2.Text = dt.Rows[0][2].ToString();
                TextBox3.Text = dt.Rows[0][3].ToString();
                TextBox4.Text = dt.Rows[0][4].ToString();
                TextBox5.Text = dt.Rows[0][5].ToString();
                ddlCustomers.Text = dt.Rows[0][6].ToString();

                //  decs = dt.Rows[0][2].ToString();

                //   add = dt.Rows[0][2].ToString();



            }

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Update DoctorReg set Name='" + TextBox1.Text + "',Address='" + TextBox2.Text + "',Mobile='" + TextBox3.Text + "',Email='" + TextBox4.Text + "',Passowrd='" + TextBox5.Text + "',Doctor_type='" + ddlCustomers.Text + "' Where Name='" + Session["dName"] + "' ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");
        
    }



}