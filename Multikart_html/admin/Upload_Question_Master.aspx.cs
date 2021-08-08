using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Upload_Question_Master : System.Web.UI.Page
{


    int Auto_Increment(string cmd1 , string str)
    {
        int cnt = 0;
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = cmd1 ;
        cmd.Connection = con;
        cnt = Convert.ToInt32(cmd.ExecuteScalar());
        
        if (cnt > 0)
        {
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = str;
            cmd2.Connection = con;
            cnt = Convert.ToInt32(cmd2.ExecuteScalar());
            cnt = cnt + 1;
        }
        else
        {
            cnt = cnt + 1;
        }
        cmd.Dispose();
        con.Close();
        return cnt;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            GetData();
        }
        //AutoIncrement Question Number Code
       // tb_Que_No.Text = Convert.ToString(Auto_Increment());

        ///Standard And Subject Loding Code
        tb_Subject.Text =  Session["Phy"].ToString();
        tb_Standard.Text = Session["Std"].ToString();

        ///DorpDownList Subject Loding Code
        try
        {
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Distinct(ChapterName) from CET_Chapter where Standard = " + tb_Standard.Text + " And Subject = '" + tb_Subject.Text + "' ", con);
            var obj = cmd.ExecuteReader();

            while(obj.Read())
            {
                dropdownlist_ChapterName.Items.Add(obj.GetString(obj.GetOrdinal("ChapterName")));
            }
            obj.Dispose();
           

            //tb_Que_No.Text = Convert.ToString(Auto_Increment("Select Count(Question_No) from CET_tbl_Question where Standard = " + tb_Standard.Text + "And Subject = '" + tb_Subject.Text + "'And ChapterName = '" + dropdownlist_ChapterName.Text + "'", "Select Max(Question_No) from CET_tbl_Question where Standard = " + tb_Standard.Text + "And Subject = '" + tb_Subject.Text + "'And ChapterName = '" + dropdownlist_ChapterName.Text + "'"));

        }
        catch (Exception ex)
        {

        }
       
    }

    private void GetData()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tbl_Question", con);
        DataTable dt = new DataTable();
        grdView.DataSource = dt;
        grdView.DataBind();
    }

    protected void dropdownlist_ChapterName_SelectedIndexChanged(object sender , EventArgs e)
    {
        //dropdownlist_ChapterName.Items.Clear();
        try
        {

            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Chapter_ID from CET_Chapter where Standard = " + tb_Standard.Text + " And Subject = '" + tb_Subject.Text + "' And ChapterName = '" + dropdownlist_ChapterName.Text + "' ", con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_ChapterNo.Text = (obj["Chapter_ID"].ToString());
            }

            obj.Dispose();

            tb_Que_No.Text = Convert.ToString(Auto_Increment("Select Count(Question_No) from CET_tbl_Question where Standard = " + tb_Standard.Text + "And Subject = '" + tb_Subject.Text + "'And Chapter_Name = '" + dropdownlist_ChapterName.Text + "'", "Select Max(Question_No) from CET_tbl_Question where Standard = " + tb_Standard.Text + "And Subject = '" + tb_Subject.Text + "'And Chapter_Name = '" + dropdownlist_ChapterName.Text + "'"));
           
        }
        catch (Exception ex)
        {

        }
        
    }
    
    protected void tb_ChapterNo_OnTextChanged(object sender,EventArgs e)
    {
        //dropdownlist_ChapterName.Items.Clear();
       

    }

    protected void dropdownlist_ChapterName_OnTextChanged(object sender,EventArgs e)
    {
        if (dropdownlist_ChapterName.Text != "")
        {
            dropdownlist_ChapterName.Items.Clear();

            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Distinct(ChapterName) from CET_Chapter where Standard = " + tb_Standard.Text + " And Subject = '" + tb_Subject.Text + "' ", con);
            var obj = cmd.ExecuteReader();

            while (obj.Read())
            {
                dropdownlist_ChapterName.Items.Add(obj.GetString(obj.GetOrdinal("ChapterName")));
            }
            obj.Dispose();
        }
    }


    protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName == "lnkbtnEdit")
        {

        }

        if(e.CommandName == "lnkbtnDelete")
        {

        }
    }

    protected void Save_Click(object sender, EventArgs e)
    {
        
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            
            string strQuery="Insert into CET_tbl_Question (Standard,Subject,Chapter_No,Chapter_Name,Question_No,Question_Name,Option_A,Option_B,Option_C,Option_D,Correct_Ans,Explanation) values(" + tb_Standard.Text + ", '" + tb_Subject.Text + "'," + tb_ChapterNo.Text + ", '" + dropdownlist_ChapterName.Text + "', " + tb_Que_No.Text + ", '" + tb_Question_Name.Text + "', '" + tb_Option_A.Text + "', '" + tb_Option_B.Text + "', '" + tb_Option_C.Text + "', '" + tb_Option_D.Text + "', '" + tb_Correct_Ans.Text + "', '" + tb_Explaination.Text + "')";

            SqlCommand cmd = new SqlCommand(strQuery);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();


            Response.Write("<script LANGUAGE='JavaSCript' > alert('Record Save Successfully')</script>");

            Clear_Control();
       
    }

    private void Clear_Control()
    {
        
        tb_ChapterNo.Text = "";
        //dropdownlist_ChapterName.Text = "";
        tb_Que_No.Text = "";
        tb_Question_Name.Text = "";
        tb_Option_A.Text = "";
        tb_Option_B.Text = "";
        tb_Option_C.Text = "";
        tb_Option_D.Text = "";
        tb_Correct_Ans.Text = "";
        tb_Explaination.Text = "";
        dropdownlist_ChapterName.SelectedIndex = -1;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
