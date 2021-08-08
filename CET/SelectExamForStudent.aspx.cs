using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SelectExamForStudent : System.Web.UI.Page
{
    public static int Form = 0;
    public static int i = 0;
    public static int RollNo;
    public static int Other = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Form = 0;

            RollNo = Convert.ToInt32(Session["RollNo"]);

            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            var i1 = Request.QueryString["other"];
            var i2 = Request.QueryString["id"];

            i = Convert.ToInt32(Request.QueryString["id"]);
            
            if (i1 == null)
            {
                string com = "Select * from CET_QuestionPaperInfo QP where QP.Exam_ID Not in (select ExamID from CET_StudentResult where RollNo = " + i + ") order by Exam_ID";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    DropDownList1.DataSource = dt;
                    DropDownList1.DataBind();
                    DropDownList1.DataTextField = "Exam_ID";
                    DropDownList1.DataValueField = "Exam_ID";
                    DropDownList1.DataBind();
                    Button1.Enabled = true;
                    DropDownList1.Enabled = true;


                }
                else
                {
                    DropDownList1.Items.Add("< All Available Exams Are Given By You >");
                    DropDownList1.Enabled = false;
                    Button1.Enabled = false;
                }
               

                Button1.Text = "Start Exam";

            }
            else
            {
                Form++;

                string com = "Select * from CET_StudentResult where RollNo = " + i + " order by ExamID";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    DropDownList1.DataSource = dt;
                    DropDownList1.DataBind();
                    DropDownList1.DataTextField = "ExamID";
                    DropDownList1.DataValueField = "ExamID";
                    DropDownList1.DataBind();
                    Button1.Enabled = true;
                    DropDownList1.Enabled = true;

                }
                else
                {
                    DropDownList1.Items.Clear();
                    DropDownList1.Items.Add("< You Have Not Given Any Exam Yet >");
                    DropDownList1.Enabled = false;
                    Button1.Enabled = false;
                }

                Button1.Text = "View Result";
            }

            
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Exam_ID"] = DropDownList1.SelectedValue;

        if (Form == 0)
        {
            Response.Redirect("StartExamforStudent.aspx?");
        }
        else
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("select id from CET_StudentResult where RollNo = " + i + " and ExamID ='" + DropDownList1.SelectedValue + "'", con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            Response.Redirect("ResultForStudent.aspx?id=" + id);
        }

    }
}