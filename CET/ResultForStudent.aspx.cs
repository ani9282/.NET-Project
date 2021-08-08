using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResultForStudent : System.Web.UI.Page
{
    static int id = 0;
    public static string Name { get; set; }
    public static int RollNo { get; set; }
    public static int ExamNo { get; set; }
    public int TotalMarks { get; set; }
    public int ObtainedMarks { get; set; }
    public int TotalQue { get; set; }
    public int SolvedQue { get; set; }
    public static int Standard { get; set; }

    public int Other = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            id = int.Parse(Request.QueryString["id"].ToString());

            string connectionString1 = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con1 = new SqlConnection(connectionString1);
            con1.Open();

            SqlCommand cmd1 = new SqlCommand("select * from CET_StudentResult where id = " + id + "", con1);

            var obj = cmd1.ExecuteReader();


            if (obj.Read())
            {
                Name = obj["Name"].ToString();
                Standard = Convert.ToInt32(obj["Standard"]);
                RollNo = Convert.ToInt32(obj["RollNo"]);
                ExamNo = Convert.ToInt32(obj["ExamID"]);
                TotalQue = Convert.ToInt32(obj["TotalQuestions"]);
                SolvedQue = Convert.ToInt32(obj["SolvedQuestions"]);
                TotalMarks = Convert.ToInt32(obj["TotalMarks"]);
                ObtainedMarks = Convert.ToInt32(obj["ObtainedMarks"]);
            }
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["RollNo"] = RollNo;
        Session["ExamID"] = ExamNo;
        Session["Standard"] = Standard;
        Session["Name"] = Name;
        Response.Redirect("StudentResultAnalysis.aspx?");
    }
}