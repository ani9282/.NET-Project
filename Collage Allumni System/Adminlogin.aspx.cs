﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
    private SqlCommand cmd;

    public object MessageBoxButtons { get; private set; }
    public object MessageBoxIcon { get; private set; }
    public object MessageBox { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
           



        con.Open();



        SqlDataAdapter da = new SqlDataAdapter("Select * from login where username='" + txtUsername.Text + "' AND password='" + txtpassword.Text + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        con.Close();
        if (dt.Rows.Count > 0)
        {
            //Response.Write("<script LANGUAGE='JavaScript' >alert('Login Successful')</script>");

            Response.Redirect("Dashboard.aspx");
        }
        else
        {

            Response.Write("Not  Successful");
            Response.Write("<script LANGUAGE='JavaScript' >alert('Login Not Successful')</script>");

        }




    }
}