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
            if (Request.QueryString["cat_id"] != null)
            {
             id=int.Parse(Request.QueryString["cat_id"].ToString());
                string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from krs_category where cat_id='" + id + "'", con);
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

        id = int.Parse(Request.QueryString["cat_id"].ToString());

        string Query = "Update krs_category set cat_name ='"+name+"' where cat_id ='"+id+"'";
        SqlCommand cmd = new SqlCommand(Query, con);
   
        cmd.Parameters.Add(new SqlParameter("@cat_id",id ));
        cmd.Parameters.Add(new SqlParameter("@cat_name", name));

        cmd.ExecuteNonQuery();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successfully')</script>");
        Response.Redirect("category.aspx");

       /* string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        id = int.Parse(Request.QueryString["id"].ToString());

        var name = this.Request.Form["cat"];
        //Access the File using the Name of HTML INPUT File.
        string filePath = FileUpload1.PostedFile.FileName;
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
        }
        if (contenttype != String.Empty)
        {


          
            Stream fs = FileUpload1.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);



            // this is a smaple query for update statement and update where id=@id
            string Query = "update tblFiles1 set Name=@name,ContentType=@ContentType,Data=@Data,Cat_Name=@Cat_Name where id=@id ";


            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@Name", filename));
            cmd.Parameters.Add(new SqlParameter("@ContentType", contenttype));
            cmd.Parameters.Add(new SqlParameter("@Data", bytes));
            cmd.Parameters.Add(new SqlParameter("@Cat_Name", name));
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successfull')</script>");

            Response.Redirect("Category.aspx");
        }*/


    }
}