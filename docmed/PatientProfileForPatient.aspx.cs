using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PatientProfileForPatient : System.Web.UI.Page
{
    int id;
  

        string rfid, dr_Name, dr_No;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["patientusername"] == null)
        {
            Response.Redirect("~/index.html");
        }


        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlDataAdapter sa = new MySqlDataAdapter("select * from Petiant where email='" + Session["patientusername"] + "'", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            rfid = dt.Rows[0][1].ToString();
            TextBox1.Text = rfid;
            TextBox2.Text = dt.Rows[0][2].ToString();
            TextBox3.Text = dt.Rows[0][3].ToString();
            TextBox4.Text = dt.Rows[0][4].ToString();
            TextBox5.Text = dt.Rows[0][5].ToString();
            TextBox6.Text = dt.Rows[0][6].ToString();
            TextBox7.Text = dt.Rows[0][7].ToString();
            TextBox8.Text = dt.Rows[0][8].ToString();
            TextBox9.Text = dt.Rows[0][9].ToString();
            TextBox10.Text = dt.Rows[0][10].ToString();
        }




        string constr1 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr1);
        con1.Open();
        MySqlCommand cmd1 = new MySqlCommand(" select * from PrescriptionDetailsDoctor NATURAL JOIN  patienttabletinfo where RFID='" + rfid + "' ", con);
        MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);
        GridView1.DataSource = dt1;
        GridView1.DataBind();


        string constr2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con2 = new MySqlConnection(constr2);
        con2.Open();
        MySqlDataAdapter sa2 = new MySqlDataAdapter("select * from patienttabletinfo where Rfid='" + rfid + "'", con2);
        DataTable dt2 = new DataTable();
        sa2.Fill(dt2);
        if (dt2.Rows.Count > 0)
        {
            TextBox11.Text = dt2.Rows[0][1].ToString();
            TextBox12.Text = dt2.Rows[0][2].ToString();
            TextBox13.Text = dt2.Rows[0][3].ToString();
            TextBox26.Text = dt2.Rows[0][4].ToString();
            TextBox27.Text = dt2.Rows[0][5].ToString();
            TextBox28.Text = dt2.Rows[0][6].ToString();

        }



        string constr3 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con3 = new MySqlConnection(constr3);
        con3.Open();
        MySqlDataAdapter sa3 = new MySqlDataAdapter("select * from PrescriptionDetailsDoctor where Rfid='" + rfid + "'", con3);
        DataTable dt3 = new DataTable();
        sa3.Fill(dt3);
        if (dt3.Rows.Count > 0)
        {
            TextBox14.Text = dt3.Rows[0][6].ToString();
            TextBox16.Text = dt3.Rows[0][7].ToString();
            TextBox17.Text = dt3.Rows[0][8].ToString();
            TextBox25.Text = dt3.Rows[0][9].ToString();


        }




    }


}