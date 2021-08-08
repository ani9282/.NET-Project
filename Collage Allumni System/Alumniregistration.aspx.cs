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


public partial class Alumniregistration : System.Web.UI.Page
{
    String data;
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=collage Alumni;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);


        string filePath = FileUpload1.PostedFile.FileName;

        string path = Path.GetFileName(FileUpload1.FileName);
        path = path.Replace(" ", " ");
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

            string strQuery = "insert into Alumniregistration(alumniid,alumniname,branchname,mobileno,email,address,photo) values (@alumniid,@alumniname,@branchname,@mobileno,@email,@address,@photo)";
            SqlCommand cmd1 = new SqlCommand(strQuery);
            cmd1.Parameters.Add("@alumniid", txtid.Text);
            cmd1.Parameters.Add("@alumniname", txtname.Text);
            cmd1.Parameters.Add("@branchname", DropDownList1.Text);
            // cmd.Parameters.Add("@branchname", product_desc.Text);
            cmd1.Parameters.Add("@mobileno", txtmobile.Text);
            cmd1.Parameters.Add("@email", txtemail.Text);
            cmd1.Parameters.Add("@address", txtadd.Text);
            cmd1.Parameters.Add("@photo", bytes);
            //cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;




            cmd1.Connection = con;
            cmd1.ExecuteNonQuery();
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

        Response.Redirect("Default3.aspx");
       
    }


    private void clear()
    {
        txtid.Text = " ";
        txtname.Text = " ";
        txtmobile.Text = " ";
        txtemail.Text = " ";
        txtadd.Text = " ";

    }




protected void Button2_Click(object sender, EventArgs e)
    {

        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select MAX(alumniid) from Alumniregistration";
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

    protected void Button4_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        //SqlCommand cmd = new SqlCommand();
        SqlCommand cmd = new SqlCommand("Delete from Alumniregistration where alumniid ='" + txtid.Text + "'", con);
        // cmd.CommandText = "Delete from staffregistration where teacherid ='" + txtid.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        GridView1.DataBind();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Delete Successful')</script>");
        cleardata();
    }
    private void cleardata()
    {
        txtid.Text = " ";
        txtname.Text = " ";
        txtmobile.Text = " ";
        txtemail.Text = " ";


    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Update Alumniregistration set alumniid='" + txtid.Text + "',alumniname='" + txtname.Text + "',branchname='" + DropDownList1.Text + "',mobileno='" + txtmobile.Text + "',Email='" + txtemail.Text + "',address='" + txtadd.Text + "',photo='" + FileUpload1 + "' where teacherid='" + txtid.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        GridView1.DataBind();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");
        clearall();

    }
    private void clearall()
    {
        txtid.Text = " ";
        txtname.Text = " ";
        txtmobile.Text = " ";
        txtemail.Text = " ";
        txtadd.Text = " ";

    }



    protected void Button5_Click(object sender, EventArgs e)
    {
        //if (FileUpload1.HasFile)
        //{
        //    string str = FileUpload1.FileName;
        //    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/image/" + str));
        //    string Image = "~/image/" + str.ToString();
        //    string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        //    SqlConnection con = new SqlConnection(conn);
        //    SqlCommand cmd = new SqlCommand("insert into Alumniregistration(photo)values('" + FileUpload1 + "')", con);
        //}

        //if (FileUpload1.HasFile)
        //{
        //    string fileName = FileUpload1.GetFileName(FileUpload1.PostedFile.FileName);
        //    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/image/") + fileName);
        //    Response.Redirect(Request.Url.AbsoluteUri);
        //}



    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtid.Text = GridView1.SelectedRow.Cells[1].Text;
        txtname.Text = GridView1.SelectedRow.Cells[2].Text;
       // DropDownList1.Text = GridView1.SelectedRow.Cells[4].Text;
        txtmobile.Text = GridView1.SelectedRow.Cells[3].Text;
        txtemail.Text = GridView1.SelectedRow.Cells[4].Text;
        txtadd.Text = GridView1.SelectedRow.Cells[5].Text;
        //FileUpload1.Text= GridView1.SelectedRow.Cells[6].Text;
        GridView1.DataBind();
    }
   

    
}


