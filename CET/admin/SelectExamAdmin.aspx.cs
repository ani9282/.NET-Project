using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_SelectExamAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string com = "Select * from CET_QuestionPaperInfo order by Exam_ID";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.DataTextField = "Exam_ID";
                DropDownList1.DataValueField = "Exam_ID";
                DropDownList1.DataBind();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string ExamID = DropDownList1.Text;
        Response.Redirect("ResultsForAdmin.aspx?id=" + ExamID);
    }
}