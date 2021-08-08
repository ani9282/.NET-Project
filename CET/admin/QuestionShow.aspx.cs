using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_QuestionShow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
           /* tb_Q_PID.Text = Session["QP_ID"].ToString();
            tb_T_Marks.Text = Session["TMarks"].ToString();
            tb_Time.Text = Session["Time"].ToString();*/

            tb_T_Marks.Text = Convert.ToString(Session["Total_Marks"]);

            tb_Time.Text = Convert.ToString(Session["Total_Time"]);

            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
            con.Open();
            /*
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("Select * From CET_Tempory_tbl", con);

            var Obj = cmd.ExecuteReader();

            while (Obj.Read())
            {
                string Std = Obj["Std"].ToString();
                string CName = Obj.GetString(Obj.GetOrdinal("Chapter_Name"));
                Obj.Close();
                SqlDataAdapter sda = new SqlDataAdapter("Select Question_Name From CET_tbl_Question Where Standard = " + Std + " And Chapter_Name='" + CName + "'",con);


                sda.Fill(dt);
                sda.Dispose();
                //Obj.Read();
                //ChkbList_Question.Items.Add = dt;

                //CheckList_Subject.DataTextField = "Subject_Name";
                CheckList_Subject.DataValueField = "Subject_ID";
                CheckList_Subject.DataSource = dt;
                CheckList_Subject.DataBind();
            }*/

            SqlDataAdapter sda = new SqlDataAdapter("Select Question_Name From CET_Tempory_tbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ChkbList_Question.DataTextField = "Question_Name";
            //ChkbList_Question.DataValueField = "Standard";
            ChkbList_Question.DataSource = dt;
            ChkbList_Question.DataBind();
            sda.Dispose();
            dt.Dispose();

            SqlCommand cmd2 = new SqlCommand("Delete From CET_Tempory_tbl", con);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            con.Close();
        }
    }

    protected void btn_View_Click(object sender, EventArgs e)
    {

    }
}