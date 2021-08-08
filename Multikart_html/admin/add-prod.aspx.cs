using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class admin_add_prod : System.Web.UI.Page
{
    string filepath;
    protected string name1 { get; set; }
    protected string price1 { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("select cat_name from krs_category");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            ddlCustomers.DataSource = cmd.ExecuteReader();
            ddlCustomers.DataTextField = "cat_name";
            ddlCustomers.DataBind();
            string Text = ddlCustomers.SelectedValue;

            con.Close();

            ddlCustomers.Items.Insert(0, new ListItem("--Select Category--", "0"));
        }

    }
   

    protected void Button1_Click(object sender, EventArgs e)
    {

        string folderPath = Server.MapPath("~/Files/");
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        string name = this.Request.Form["prod_name"];
        string price = this.Request.Form["prod_price"];
        String SixthImageUrl = Session["path"].ToString();
        string Text = ddlCustomers.SelectedValue;

        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string strQuery = "insert into krs_products(prod_name,prod_price,prod_img,prod_category) values('"+name+"','"+price+"','"+ SixthImageUrl + "','"+Text+"')";
        SqlCommand cmd = new SqlCommand(strQuery);
       
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Added Successfull')</script>");
        Session["filepath"] = null;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string folderPath = Server.MapPath("~/Files/");

        //Check whether Directory (Folder) exists.
        if (!Directory.Exists(folderPath))
        {
            //If Directory (Folder) does not exists Create it.
            Directory.CreateDirectory(folderPath);
        }

        //Save the File to the Directory (Folder).
        FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
        String finalpath = folderPath + Path.GetFileName(FileUpload1.FileName);
        Session["path"] = finalpath;


        //Display the Picture in Image control.
        Image1.ImageUrl = "~/Files/" + Path.GetFileName(FileUpload1.FileName);

    }

   
}