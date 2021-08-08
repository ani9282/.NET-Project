using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;

public partial class Staffregistraion : System.Web.UI.Page
{
    String data;
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=collage Alumni;Integrated Security=True");
    //private SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);

        string filePath = FileUpload1.PostedFile.FileName;

        string path = Path.GetFileName(FileUpload1.FileName);
       // path = path.Replace(" ", " ");
        String FileName1 = path;
        FileUpload1.SaveAs(Server.MapPath("/image/") + path);
        //HyperLink1.NavigateUrl = "/ViewImages.aspx?FileName=" + FileName1;
        //HyperLink1.Visible = true;
        Label1.Text = "Save successfuly..";




        if (FileUpload1.HasFile)
        {
            string str = FileUpload1.FileName.ToString();
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/image/~") + str);


            Stream fs = FileUpload1.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);


            con.Open();

            string strQuery = "insert into staffregistration(teacherid,teachername,branchname,mobileno,email,address,photo) values (@teacherid,@teachername,@branchname,@mobileno,@email,@address,@photo)";
                SqlCommand cmd = new SqlCommand(strQuery);
            cmd.Parameters.Add("@teacherid", txtid.Text);
            cmd.Parameters.Add("@teachername", txtname.Text);
            cmd.Parameters.Add("@branchname", DropDownList1.Text);
           // cmd.Parameters.Add("@branchname", product_desc.Text);
            cmd.Parameters.Add("@mobileno", txtmobile.Text);
            cmd.Parameters.Add("@email", TextBox1.Text);
            cmd.Parameters.Add("@address", txtadd.Text);
            cmd.Parameters.Add("@photo", bytes);
            //cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;


           

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Visible = true;
            Label1.Text = "Image Uploaded successfully";

        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Plz upload the image!!!!";
        }
        clear();
        GridView1.DataBind();
        Response.Redirect("Default3.aspx");

    }




        
        


            ////        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            ////    SqlConnection con = new SqlConnection(conn);
            ////    con.Open();
            ////    SqlCommand cmd = new SqlCommand("insert into staffregistration (teacherid,teachername,branchname,mobileno,email,address,photo)values('" + txtid.Text + "','" + txtname.Text + "','" + DropDownList1.Text + "','" + txtmobile.Text + "','" + TextBox1.Text + "','" + txtadd.Text + "' ,'" + FileUpload1 + "')", con);

        ////    // SqlCommand cmd= new SqlCommand("insert into staffregistration  id'" + txtid.Text + "',Teacher name ='" + txtname.Text + "', mobile='" + txtmobile.Text + "',Email='" + txtemail.Text + "',address='" + txtadd.Text + "'", con);
        ////    cmd.Connection = con;
        ////    cmd.ExecuteNonQuery();


        ////    Response.Write("<script LANGUAGE='JavaScript' >alert('save Successful')</script>");

        ////     Response.Redirect("Dashboard.aspx");
        ////}



        




    private void clear()
    {
        txtid.Text = " ";
        txtname.Text = " ";
        txtmobile.Text = " ";
        TextBox1.Text = " ";
        //txtbranch.Text = " ";
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select MAX(teacherid) from staffregistration";
        cmd.Connection = con;
        int i = 0;
        try
        {
            i = Convert.ToInt32(cmd.ExecuteScalar());
            i++;
            txtid.Text = i.ToString();
        }
        catch (Exception ex)
        {

            txtid.Text = "1";

            cmd.ExecuteNonQuery();


        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update staffregistration set teacherid='" + txtid.Text + "',Teachername='" + txtname.Text + "',branchname='" + DropDownList1.Text + "',mobileno='" + txtmobile.Text + "',email='" + TextBox1.Text + "',address='" + txtadd.Text + "',photo='" + FileUpload1 + "' where teacherid='" + txtid.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();


        clearall();
        GridView1.DataBind();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");

    }
    private void clearall()
    {
        txtid.Text = " ";
        txtname.Text = " ";
        txtmobile.Text = " ";
        TextBox1.Text = " ";


    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        //SqlCommand cmd = new SqlCommand();
        SqlCommand cmd = new SqlCommand("Delete from staffregistration where teacherid ='" + txtid.Text + "'", con);
        // cmd.CommandText = "Delete from staffregistration where teacherid ='" + txtid.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();
        cleardata();
        GridView1.DataBind();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Delete Successful')</script>");
    }
    private void cleardata()
    {
        txtid.Text = " ";
        txtname.Text = " ";
        txtmobile.Text = " ";
        TextBox1.Text = " ";
        txtadd.Text = " ";


    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtid.Text = GridView1.SelectedRow.Cells[1].Text;
        txtname.Text = GridView1.SelectedRow.Cells[2].Text;
       // DropDownList1.Text = GridView1.SelectedRow.Cells[3].Text;
        txtmobile.Text = GridView1.SelectedRow.Cells[3].Text;
        TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
        txtadd.Text = GridView1.SelectedRow.Cells[5].Text;
        //FileUpload1.Text= GridView1.SelectedRow.Cells[6].Text;
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        ////if (FileUpload1.HasFile)
        ////{
        ////    string str = FileUpload1.FileName;
        ////    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/image/" + str));
        ////    string Image = "~/image/" + str.ToString();
        ////    string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        ////    SqlConnection con = new SqlConnection(conn);
        ////    SqlCommand cmd = new SqlCommand("insert into staffregistration(photo)values('" + FileUpload1 + "')", con);
        ////}
        //string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        //SqlConnection con = new SqlConnection(conn);
        //string path = "~/image/" + FileUpload1.FileName;
        //string query = "insert into staffregistration values( '" + FileUpload1 + "')";
        ////SqlCommand cmd = new SqlCommand("insert into staffregistration(teacherid,photo)values( '" + txtid + "''" + FileUpload1 + "')", con);
        //FileUpload1.SaveAs(Server.MapPath("image") + "/" + FileUpload1.FileName);
        //con.Open();
        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = con;
        ////cmd.ExecuteNonQuery();
        //cmd.CommandText = query;
        //int x = cmd.ExecuteNonQuery();
        //con.Close();
        //if (x > 0)
        //{

        //    Response.Write("Item inserted Successfully");

        //}
        //else
        //{
        //    Response.Write("Try Again");

        //}






    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }
}
    