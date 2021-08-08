﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PatientHistoryDD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["dName"] == null)
        {
            Response.Redirect("~/index.html");
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Request.Form["id"];
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        try
        {
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from PrescriptionDetailsDoctor NATURAL JOIN  patienttabletinfo where RFID='" + id + "' ", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
        catch
        {


        }
    }
}