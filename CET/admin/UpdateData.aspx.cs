using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class back_end_UpdateData : System.Web.UI.Page
{
    int id;
    public string ServerValue = String.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["Subject_ID"] != null)
            {
             id=int.Parse(Request.QueryString["Subject_ID"].ToString());
                string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from CET_tblSubject where Subject_ID='" + id + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ServerValue = dt.Rows[0][1].ToString();
                }
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var name = this.Request.Form["cat"];
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        id = int.Parse(Request.QueryString["Subject_ID"].ToString());

        string Query = "Update CET_tblSubject set Subject_Name = @Subject_Name where Subject_ID = @Subject_ID";
        SqlCommand cmd = new SqlCommand(Query, con);
   
        cmd.Parameters.Add(new SqlParameter("@Subject_ID",id ));
        cmd.Parameters.Add(new SqlParameter("@Subject_Name", name));

        cmd.ExecuteNonQuery();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successfully')</script>");
        Response.Redirect("category.aspx");
    }
}