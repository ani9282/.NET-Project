﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class back_end_Update_ChapterMaster : System.Web.UI.Page
{
    public string ServerValue = String.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        if(!IsPostBack)
        {
            GetDataItem();
        }*/
        if (!IsPostBack)
        {
            if (Request.QueryString["Subject_ID"] != null)
            {
                string std = Request.QueryString["Standard"];
                string Sub = Request.QueryString["Subject"];
                string CNo = Request.QueryString["CNo"];
                string CName = Request.QueryString["CName"];

                string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select ChapterName from CET_Chapter where Standard = " + std + " And Subject = '" + Sub + "' And Chapter_ID = '" + CNo + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    ServerValue = dt.Rows[0][1].ToString();
                }

            }

        }

       
    }
    /*
    public void getData()
    {
        
        
        string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter("select ChapterName from CET_Chapter where Standard = " + tb_Standard.Text + " And Subject = '" + tb_Subject.Text + "' And Chapter_ID = '" + tb_ChapterID.Text + "' ", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        if(dt.Rows.Count > 0)
        {
             ServerValue = dt.Rows[0][1].ToString();
        }

        
    }*/

    protected void Button1_Click(object sender, EventArgs e)
    {        
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string Query = "Update CET_Chapter SET ChapterName='" + tb_ChapterName.Text + "' where Standard = " + tb_Standard.Text + " And Subject = '" + tb_Subject.Text + "' And Chapter_ID=" + tb_ChapterID.Text + "";
        SqlCommand cmd = new SqlCommand(Query, con);
        cmd.ExecuteNonQuery();
        Response.Write("<Script LANGUAGE ='JavaScript'> alert ('Update Successfully')</Script>");
        Response.Redirect("add-product.aspx");
    }
}