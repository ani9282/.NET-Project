using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentResultAnalysis : System.Web.UI.Page
{
    public static int RollNo { get; set; }
    public static int Std { get; set; }
    public static int ExamNo { get; set; }
    public static string Name { get; set; }

    public int Other = 0;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
             Std = Convert.ToInt32(Session["Standard"]);
             RollNo = Convert.ToInt32(Session["RollNo"]);
             ExamNo = Convert.ToInt32(Session["ExamID"]);
             Name = Session["Name"].ToString();


            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt1 = new DataTable();
            string Query1 = "Select SE.Question_No,SE.Option_A,SE.Option_B,SE.Option_C,SE.Option_D,SE.Correct_Ans,EA.SelectedOption,SE.Explanation,AnswerStatus from CET_Select_Exam_Question As SE left outer join CET_Exam_AnswerSheet As EA on(SE.Que_Paper_id = EA.PaperID and SE.Question_No = EA.Question) where SE.Que_Paper_id = " + ExamNo + " and EA.Standard = " + Std + " And EA.RollNo = " + RollNo + " and EA.PaperID = " + ExamNo + "";
            //select rp.rsrpID as ID, rp.rsrpName as Name, ri.rsrisesdID
            //from resourcepool rp
            //left outer join resourcesintroduced ri on (ri.rsrirsrpID = rp.rsrpID and ri.rsrisesdID = 243)
            SqlDataAdapter sda1 = new SqlDataAdapter(Query1, con);
            sda1.Fill(dt1);
            abc.DataSource = dt1;
            abc.DataBind();
        }
    }

    protected void abc_PreRender(object sender, EventArgs e)
    {
        abc.HeaderRow.TableSection = TableRowSection.TableHeader;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}