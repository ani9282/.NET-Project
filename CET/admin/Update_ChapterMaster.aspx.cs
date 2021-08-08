using System;
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
    public string sub = String.Empty;
    public string CNo = String.Empty;
    public string CName = String.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
        
        
            if (Request.QueryString["Standard"] != null)
            {
                ServerValue = Request.QueryString["Standard"];
                sub = Request.QueryString["Subject"];
                CNo = Request.QueryString["CNo"];
               CName = Request.QueryString["CName"];

               


            }

        
  
    }
   

    protected void Button1_Click(object sender, EventArgs e)
    {        
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        String std = Request.Form["cat"];
        String sub = Request.Form["cat1"];
        String chapterid = Request.Form["cat2"];

        String chname = Request.Form["cat3"];
         string Query = "Update CET_Chapter SET ChapterName='" + chname + "' where Standard = " + std + " And Subject = '" + sub + "' And Chapter_ID=" + chapterid + "";
        SqlCommand cmd = new SqlCommand(Query, con);
         cmd.ExecuteNonQuery();
        Response.Write("<Script LANGUAGE ='JavaScript'> alert ('Update Successfully')</Script>");
        Response.Redirect("EditChapter.aspx");
    }
}