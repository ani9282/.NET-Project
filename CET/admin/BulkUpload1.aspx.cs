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


public partial class admin_BulkUpload1 : System.Web.UI.Page
{



    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            /// Dtabase Subject Loding Code
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tblSubject ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int cnt = dt.Rows.Count;

            for (int i = 0; i <= cnt; i++)
            {
                if (i == 0)
                {
                    Btn_Physics.Visible = true;
                    Btn_Physics.Text = dt.Rows[i][1].ToString();

                }

                if (i == 1)
                {
                    Btn_Chemistry.Visible = true;
                    Btn_Chemistry.Text = dt.Rows[i][1].ToString();
                }

                if (i == 2)
                {
                    Btn_Maths.Visible = true;
                    Btn_Maths.Text = dt.Rows[i][1].ToString();

                }

                if (i == 3)
                {
                    Btn_Biology.Visible = true;
                    Btn_Biology.Text = dt.Rows[i][1].ToString();
                }

            }



        }
        catch (Exception ex)
        {

            // throw;
        }

    }

    //Standard And Subject Loding another Page Coding
    protected void Btn_Physics_Click(object sender, EventArgs e)
    {
        try
        {
            string str = null;


            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tblSubject", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int cnt = dt.Rows.Count;
            for (int i = 0; i < cnt; i++)
            {
                if (i == 0)
                {
                    Btn_Physics.Visible = true;
                    str = dt.Rows[i][1].ToString();
                }
            }

            Session["Phy1"] = Btn_Physics.Text;
            Session["Std1"] = DDL_Std.Text;
            Response.Redirect("Upload_Complex_Reaction.aspx?");

        }
        catch (Exception ex)
        {

            //throw;
        }

    }

    //Standard And Subject Loding another Page Coding
    protected void Btn_Maths_Click(object sender, EventArgs e)
    {
        try
        {
            string str = null;


            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tblSubject", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int cnt = dt.Rows.Count;
            for (int i = 0; i < cnt; i++)
            {
                if (i == 1)
                {
                    Btn_Maths.Visible = true;
                    str = dt.Rows[i][1].ToString();
                }
            }
            Session["Phy1"] = Btn_Maths.Text;
            Session["Std1"] = DDL_Std.Text;
            Response.Redirect("Upload_Complex_Reaction.aspx?");

        }
        catch (Exception ex)
        {

            // throw;
        }

    }

    //Standard And Subject Loding another Page Coding
    protected void Btn_Biology_Click(object sender, EventArgs e)
    {
        try
        {
            string str = null;

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tblSubject", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int cnt = dt.Rows.Count;
            for (int i = 0; i < cnt; i++)
            {
                if (i == 2)
                {
                    Btn_Biology.Visible = true;
                    str = dt.Rows[i][1].ToString();
                }
            }
            Session["Phy1"] = Btn_Biology.Text;
            Session["Std1"] = DDL_Std.Text;
            Response.Redirect("Upload_Complex_Reaction.aspx?");
        }
        catch (Exception ex)
        {




            //throw;
        }

    }

    //Standard And Subject Loding another Page Coding
    protected void Btn_Chemistry_Click(object sender, EventArgs e)
    {
        try
        {
            string str = null;


            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tblSubject", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int cnt = dt.Rows.Count;
            for (int i = 0; i < cnt; i++)
            {
                if (i == 3)
                {
                    Btn_Chemistry.Visible = true;
                    str = dt.Rows[i][1].ToString();
                }
            }
            Session["Phy1"] = Btn_Chemistry.Text;
            Session["Std1"] = DDL_Std.Text;
            Response.Redirect("Upload_Complex_Reaction.aspx?");

        }
        catch (Exception ex)
        {

            //throw;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*DataTable tblcsv = new DataTable();
        //creating columns  
        tblcsv.Columns.Add("PID");
        tblcsv.Columns.Add("title");
        tblcsv.Columns.Add("price");
        tblcsv.Columns.Add("PCode");
        tblcsv.Columns.Add("PSize");
        tblcsv.Columns.Add("totalproducts");
        tblcsv.Columns.Add("description");
        tblcsv.Columns.Add("Cat_Name");
        tblcsv.Columns.Add("ProductType");
        tblcsv.Columns.Add("DiscountPrice");
        tblcsv.Columns.Add("discount");
        tblcsv.Columns.Add("Image1Url");
        tblcsv.Columns.Add("Image2Url");
        tblcsv.Columns.Add("Image3Url");
        tblcsv.Columns.Add("Image4Url");
        tblcsv.Columns.Add("Image5Url");
        tblcsv.Columns.Add("Image6Url");
        //getting full file path of Uploaded file  
        string ext = Path.GetExtension(FileUpload1.FileName).ToLower();
        //getting the path of the file   
        string path = Server.MapPath("~/CSV/" + FileUpload1.FileName);
        //saving the file inside the MyFolder of the server  
        FileUpload1.SaveAs(path);
        //Reading All text  
        string ReadCSV = File.ReadAllText(path);
        //spliting row after new line  
        foreach (string csvRow in ReadCSV.Split('\n'))
        {
            if (!string.IsNullOrEmpty(csvRow))
            {
                //Adding each row into datatable  
                tblcsv.Rows.Add();
                int count = 0;
                foreach (string FileRec in csvRow.Split(','))
                {
                    tblcsv.Rows[tblcsv.Rows.Count - 1][count] = FileRec;
                    count++;
                }
            }


        }
        //Calling insert Functions  
        InsertCSVRecords(tblcsv);*/
    }

    private void InsertCSVRecords(DataTable csvdt)
    {
        /* string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
         SqlConnection con = new SqlConnection(connectionString);



         con.Open();

         //creating object of SqlBulkCopy  
         SqlBulkCopy objbulk = new SqlBulkCopy(con);
         //assigning Destination table name  
         objbulk.DestinationTableName = "tbl_products";
         //Mapping Table column  
         objbulk.ColumnMappings.Add("PID", "PID");
         objbulk.ColumnMappings.Add("title", "title");
         objbulk.ColumnMappings.Add("price", "price");
         objbulk.ColumnMappings.Add("PCode", "PCode");
         objbulk.ColumnMappings.Add("PSize", "PSize");
         objbulk.ColumnMappings.Add("totalproducts", "totalproducts");
         objbulk.ColumnMappings.Add("description", "description");
         objbulk.ColumnMappings.Add("Cat_Name", "Cat_Name");
         objbulk.ColumnMappings.Add("ProductType", "ProductType");
         objbulk.ColumnMappings.Add("DiscountPrice", "DiscountPrice");
         objbulk.ColumnMappings.Add("discount", "discount");
         objbulk.ColumnMappings.Add("Image1Url", "Image1Url");
         objbulk.ColumnMappings.Add("Image2Url", "Image2Url");
         objbulk.ColumnMappings.Add("Image3Url", "Image3Url");
         objbulk.ColumnMappings.Add("Image4Url", "Image4Url");
         objbulk.ColumnMappings.Add("Image5Url", "Image5Url");
         objbulk.ColumnMappings.Add("Image6Url", "Image6Url");
         //inserting Datatable Records to DataBase  

         objbulk.WriteToServer(csvdt);
         con.Close();*/


    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}