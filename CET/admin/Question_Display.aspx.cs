using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Question_Display : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        DataTable dt = new DataTable();

        string Std= Session["Std"].ToString();
        string TotalMarks = Session["TMarks"].ToString();
        string Time= Session["Time"].ToString();

        string sentence = Session["All_Chapters"].ToString();
        string[] array = sentence.Split('$');

        foreach (string val in array.Where(i => !string.IsNullOrEmpty(i)))
        {
            string Query1 = "Select * from CET_tbl_Question Where Standard = " + Std + " And Chapter_Name ='" + val +"'";
            SqlDataAdapter sda1 = new SqlDataAdapter(Query1, con);
            sda1.Fill(dt);
            abc.DataSource = dt;
            abc.DataBind();
            con.Close();
        }
       
    }

    protected void btn_View_Click(object sender, EventArgs e)
    {

        foreach (GridViewRow row1 in abc.Rows)
        {
            if ((row1.FindControl("xyz") as CheckBox).Checked)
            {


                //int Number = Convert.ToInt32((row.Cells[3].FindControl("lbl_Chapter_No") as Label).Text);
                string standard = (row1.Cells[1].FindControl("a") as Label).Text;
                string subject = (row1.Cells[2].FindControl("b") as Label).Text;
                string chap_name = (row1.Cells[3].FindControl("c") as Label).Text;
                string q_name = (row1.Cells[4].FindControl("d") as Label).Text;
                string A = (row1.Cells[5].FindControl("e") as Label).Text;
                string B = (row1.Cells[6].FindControl("f") as Label).Text;
                string C = (row1.Cells[7].FindControl("g") as Label).Text;
                string D = (row1.Cells[8].FindControl("h") as Label).Text;
                string correct_ans = (row1.Cells[9].FindControl("i") as Label).Text;
                string explanation = (row1.Cells[10].FindControl("j") as Label).Text;

            }
            
        }
      

    }
}