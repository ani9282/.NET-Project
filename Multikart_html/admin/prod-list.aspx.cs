using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class admin_prod_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getData();
        }

    }
    public void getData()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);




        con.Open();

        //SqlDataAdapter da = new SqlDataAdapter("select id,Cat_Name,Data from tblFiles1", con);
        SqlDataAdapter da = new SqlDataAdapter("select prod_id,prod_name,prod_category from krs_products", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        grdView.DataSource = dt;
        grdView.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        var name = this.Request.Form["cat"];
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string strQuery = "insert into krs_category(cat_name) values(@cat_name)";
        SqlCommand cmd = new SqlCommand(strQuery);
        cmd.Parameters.Add("@cat_name", SqlDbType.VarChar).Value = name;

        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Added Successfull')</script>");
        getData();

        //Access the File using the Name of HTML INPUT File.
        /* string filePath = FileUpload1.PostedFile.FileName;
         string filename = Path.GetFileName(filePath);
         string ext = Path.GetExtension(filename);
         string contenttype = String.Empty;
         string filePath1 = Server.MapPath("~/Uploads/") + Path.GetFileName(filePath);
         FileUpload1.SaveAs(filePath1);
         //Set the contenttype based on File Extension
         switch (ext)
         {
             case ".doc":
                 contenttype = "application/vnd.ms-word";
                 break;
             case ".docx":
                 contenttype = "application/vnd.ms-word";
                 break;
             case ".xls":
                 contenttype = "application/vnd.ms-excel";
                 break;
             case ".xlsx":
                 contenttype = "application/vnd.ms-excel";
                 break;
             case ".jpg":
                 contenttype = "image/jpg";
                 break;
             case ".png":
                 contenttype = "image/png";
                 break;
             case ".gif":
                 contenttype = "image/gif";
                 break;
             case ".pdf":
                 contenttype = "application/pdf";
                 break;
         }*/
        /*if (contenttype != String.Empty)
        { 
              string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
              SqlConnection con = new SqlConnection(connectionString);
              //var name = this.Request.Form["cat"];



              con.Open();
              Stream fs = FileUpload1.PostedFile.InputStream;
              BinaryReader br = new BinaryReader(fs);
              Byte[] bytes = br.ReadBytes((Int32)fs.Length);

              //insert the file into database
              string strQuery = "insert into tblFiles1(Name, ContentType, Data,Cat_Name) values (@Name, @ContentType, @Data,@Cat_Name)";
              
              SqlCommand cmd = new SqlCommand(strQuery);
              cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = filename;
              cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value = contenttype;
              cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
              cmd.Parameters.Add("@Cat_Name", SqlDbType.VarChar).Value = name;

              cmd.Connection = con;
              cmd.ExecuteNonQuery();
              Response.Write("<script LANGUAGE='JavaScript' >alert('Added Successfull')</script>");
              getData();
          }
          else
          {

          }*/
    }


    protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        /* This condition work when click on edit button */
        if (e.CommandName == "lnkbtnEdit")
        {
            int id = int.Parse(e.CommandArgument.ToString());

            Response.Redirect("Updateproduct.aspx?prod_id=" + id); /* Pass id in querystring for updating record */
            //Response.Redirect("UpdateData.aspx?Subject_Name = name ");
            getData();
        }

        /* This condition work when click on delete button */
        if (e.CommandName == "lnkbtnDelete")
        {
            int id = int.Parse(e.CommandArgument.ToString());
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            var name = this.Request.Form["prod_name"];





            //SqlCommand cmd = new SqlCommand("delete from tblFiles1 where ID='" + id + "'", con);
            SqlCommand cmd = new SqlCommand("delete from krs_products where prod_id='" + id + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            getData(); /* Reload gridview */
        }
    }
}