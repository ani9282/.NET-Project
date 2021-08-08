using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class admin_QDisplay : System.Web.UI.Page
{
    public string Que_Paper_Id = null;

    public static string Time;
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        DataTable dt = new DataTable();
        string Std = Session["Std"].ToString();
        string TotalMarks = Session["TMarks"].ToString();
        Time = Session["Time"].ToString();
        Que_Paper_Id=Session["Que_Id"].ToString();
        string sentence = Session["All_Chapters"].ToString();
        string[] array = sentence.Split('$');

        foreach (string val in array.Where(i => !string.IsNullOrEmpty(i)))
        {
            string Query1 = "Select * from CET_tbl_Question Where Standard = " + Std + " And Chapter_Name ='" + val + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(Query1, con);
            sda1.Fill(dt);
            abc.DataSource = dt;
            abc.DataBind();
            //con.Close();
        }

    }


    protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       
        if (e.CommandName == "lnkbtnDelete")
        {

            string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });

            string Standard = commandArgs[0];
            string Subject = commandArgs[1];
            string Chapter_No = commandArgs[2];
            string Chapter_Name = commandArgs[3];
            string Question_Name = commandArgs[4];
            string Question_No = commandArgs[5];
            string Option_A = commandArgs[6];
            string Option_B = commandArgs[7];
            string Option_C = commandArgs[8];
            string Option_D = commandArgs[9];
            string Correct_Ans = commandArgs[10];
            string Explanation = commandArgs[11];
            string Q_ID = commandArgs[12];
            
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
            con.Open();

            // string strQuery = "insert into CET_Chapter(Standard,Subject,Chapter_ID,ChapterName) values (@Standard,@Subject,@ChapterNo,@ChapterNo)";
            string strQuery = "insert into CET_Select_Exam_Question(Standard,Subject,Chapter_No,Chapter_Name,Question_Name,Question_No,Option_A,Option_B,Option_C,Option_D,Correct_Ans,Explanation,Q_ID,Que_Paper_Id) values ('" + Standard + "', '" + Subject + "', '" + Chapter_No + "', '" + Chapter_Name + "','" + Question_No + "','" + Question_Name + "','" + Option_A + "','" + Option_B + "','" + Option_C + "','" + Option_D + "','" + Correct_Ans + "','" + Explanation + "','" + Q_ID + "','" + Que_Paper_Id + "')";
            SqlCommand cmd = new SqlCommand(strQuery);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaSCript' > alert('Record Added Successfully')</script>");

        }
    }


    protected void btn_View_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        int Std = Convert.ToInt32(Session["Std"]);
        int TotalMarks = Convert.ToInt32(Session["TMarks"]);

        string strQuery = "insert into CET_QuestionPaperInfo(Exam_ID,Standard,Time,Total_Marks) values (" + Que_Paper_Id + "," + Std + "," + Time + "," + TotalMarks + ")";
        SqlCommand cmd = new SqlCommand(strQuery,con);

        cmd.ExecuteNonQuery();

        Response.Write("<script LANGUAGE='JavaSCript' > alert('Exam Created Successfully'); window.location='Dashboard.aspx';</script>");
    }

    protected void abc_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}