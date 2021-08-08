using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StartExamforStudent : System.Web.UI.Page
{
    public static int id = 0;
    public string username = null;
    public int Roll_No = 0;
    public int RollNo = 0;
    public string name = null;
    public string fname = null;
    public string lname = null;
    public string std = null;
    public string Qption_A = null;
    public string Qption_B = null;
    public string Qption_C = null;
    public string Qption_D = null;
    public static int Que_No = 0;
    public static int i = 0;
    static int Exam_ID = 0;
    public static int[] Arr;
    static string PID = "";
    string QID = "";
    string Question = "";
    string CO = "";
    string Explanation = "";
    string ExamID = "";
    string Subject = "";
    string AS = "";
    string SO = "";
    static int SubClick = 0;

    public static int ExamTime = 0;

    public static string Date;

    public static DateTime Date1;

    public static string Deadline;

    public static int i1 = -1;

    public static int i2 = -1;

    public static void GlobalData()
    {
        string connectionString1 = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con1 = new SqlConnection(connectionString1);
        con1.Open();

        SqlCommand cmd = new SqlCommand("select Total_Marks from CET_QuestionPaperInfo where Exam_ID =" + Exam_ID + "", con1);
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        Arr = new int[i];
    }
    protected void Page_Load(object sender, EventArgs e)
    {
            Date = DateTime.Now.ToString("MMM dd, yyyy HH:mm:ss");
            username = Session["student"].ToString();
            Roll_No = Convert.ToInt32(Session["RollNo"]);
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from CET_tbl_Student_Register where Mobile_No='" + username + "' and Student_ID = " + Roll_No + "", con);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                RollNo = Convert.ToInt32(dt.Rows[0][0]);
                name = dt.Rows[0][1].ToString();
                fname = dt.Rows[0][2].ToString();
                lname = dt.Rows[0][3].ToString();
                std = dt.Rows[0][4].ToString();
            }
        //RadioButton1.Checked = false;
        //RadioButton2.Checked = false;
        //RadioButton3.Checked = false;
        //RadioButton4.Checked = false;
        

        //con.Close();
        if (!IsPostBack)
        {
           
            SubClick = 0;
            Que_No = 0;
            Exam_ID = Convert.ToInt32(Session["Exam_ID"]);
            string connectionString1 = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con1 = new SqlConnection(connectionString1);
            con1.Open();

            GlobalData();

            SqlDataAdapter sa1 = new SqlDataAdapter("select * from CET_Select_Exam_Question where Que_Paper_Id =" + Exam_ID + "", con1);
            DataTable dt1 = new DataTable();
            sa1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                Que_No++;
                Label1.Text = Que_No.ToString();
                id = int.Parse(dt1.Rows[0][0].ToString());
                Label2.Text = dt1.Rows[0][5].ToString();
                RadioButton1.Text = dt1.Rows[0][7].ToString();
                RadioButton2.Text = dt1.Rows[0][8].ToString();
                RadioButton3.Text = dt1.Rows[0][9].ToString();
                RadioButton4.Text = dt1.Rows[0][10].ToString();

            }
        }
        if (i1 != Exam_ID || i2 != RollNo)
        {
            i1 = Exam_ID;
            i2 = RollNo;

            string connectionString1 = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con1 = new SqlConnection(connectionString1);
            con1.Open();

            SqlCommand cmd = new SqlCommand("select Time from CET_QuestionPaperInfo where Exam_ID =" + Exam_ID + "", con);

            ExamTime = Convert.ToInt32(cmd.ExecuteScalar());

            //ExamTime = 1;// Convert.ToInt64( DateTime.Now);

            Date1 = DateTime.Now;

            Date1 = Date1.AddMinutes(ExamTime);

            Deadline = Date1.ToString("MMM dd, yyyy HH:mm:ss");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button3_Click(sender, e);
        id--;
        string connectionString1 = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con1 = new SqlConnection(connectionString1);
        con1.Open();
        SqlDataAdapter sa1 = new SqlDataAdapter("select * from CET_Select_Exam_Question where Standard='" + std + "'and id='" + id + "'and Que_Paper_Id =" + Exam_ID + "", con1);
        DataTable dt1 = new DataTable();
        sa1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            Que_No--;
            Label1.Text = Que_No.ToString();
            id = int.Parse(dt1.Rows[0][0].ToString());
            Label2.Text = dt1.Rows[0][5].ToString();
            RadioButton1.Text = dt1.Rows[0][7].ToString();
            RadioButton2.Text = dt1.Rows[0][8].ToString();
            RadioButton3.Text = dt1.Rows[0][9].ToString();
            RadioButton4.Text = dt1.Rows[0][10].ToString();
            if (Arr[Que_No] == 1 || Arr[Que_No] == 2 || Arr[Que_No] == 3 || Arr[Que_No] == 4)
            {

                RadioButton1.Checked = false;
                RadioButton2.Checked = false;
                RadioButton3.Checked = false;
                RadioButton4.Checked = false;

                if (Arr[Que_No] == 1)
                {
                    RadioButton1.Checked = true;
                    RadioButton1.Enabled = true;
                }
                else if (Arr[Que_No] == 2)
                {
                    RadioButton2.Checked = true;
                    RadioButton2.Enabled = true;
                }
                else if (Arr[Que_No] == 3)
                {
                    RadioButton3.Checked = true;
                    RadioButton3.Enabled = true;

                }
                else if (Arr[Que_No] == 4)
                {
                    RadioButton4.Checked = true;
                    RadioButton4.Enabled = true;
                }
            }
            else
            {

                RadioButton1.Checked = false;
                RadioButton2.Checked = false;
                RadioButton3.Checked = false;
                RadioButton4.Checked = false;
    
                Button3.Enabled = true;
            }

        }
        else
        {
            id++;
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //next Button event 
        Button3_Click(sender, e);
        id++;   
        string connectionString1 = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con1 = new SqlConnection(connectionString1);
        con1.Open();
        SqlDataAdapter sa1 = new SqlDataAdapter("select * from CET_Select_Exam_Question where Standard='" + std + "'and id='" + id + "'and Que_Paper_Id =" + Exam_ID + "", con1);
        DataTable dt1 = new DataTable();
        sa1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            Que_No++;
            Label1.Text = Que_No.ToString();
            id = int.Parse(dt1.Rows[0][0].ToString());
            Label2.Text = dt1.Rows[0][5].ToString();
            RadioButton1.Text = dt1.Rows[0][7].ToString();
            RadioButton2.Text = dt1.Rows[0][8].ToString();
            RadioButton3.Text = dt1.Rows[0][9].ToString();
            RadioButton4.Text = dt1.Rows[0][10].ToString();
            if (Arr[Que_No] == 1 || Arr[Que_No] == 2 || Arr[Que_No] == 3 || Arr[Que_No] == 4)
            {
                RadioButton1.Enabled = true;
                RadioButton2.Enabled = true;
                RadioButton3.Enabled = true;
                RadioButton4.Enabled = true;

                RadioButton1.Checked = false;
                RadioButton2.Checked = false;
                RadioButton3.Checked = false;
                RadioButton4.Checked = false;

                if (Arr[Que_No] == 1)
                {
                    RadioButton1.Checked = true;
                    RadioButton1.Enabled = true;
                }
                else if (Arr[Que_No] == 2)
                {
                    RadioButton2.Checked = true;
                    RadioButton2.Enabled = true;
                }
                else if (Arr[Que_No] == 3)
                {
                    RadioButton3.Checked = true;
                    RadioButton3.Enabled = true;
                }
                else if (Arr[Que_No] == 4)
                {
                    RadioButton4.Checked = true;
                    RadioButton4.Enabled = true;
                }
            }
            else
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = false;
                RadioButton3.Checked = false;
                RadioButton4.Checked = false;
                Button3.Enabled = true;
            }
        }
        else
        {
            id--;
        }

    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        if (RadioButton1.Checked || RadioButton2.Checked || RadioButton3.Checked || RadioButton4.Checked)
        {
            //Submit Button Code
            ++SubClick;
            string connectionString1 = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con1 = new SqlConnection(connectionString1);
            con1.Open();

            string FullName = name + " " + fname + " " + lname;

            SqlCommand cmd = new SqlCommand("select * from CET_Select_Exam_Question where Standard='" + std + "'and id='" + id + "'", con1);
            var obj = cmd.ExecuteReader();

            obj.Read();
            PID = obj["Que_Paper_id"].ToString();
            QID = obj["id"].ToString();
            Question = obj["Question_No"].ToString();
            CO = obj["Correct_Ans"].ToString();
            Explanation = obj["Explanation"].ToString();
            ExamID = "5";
            Subject = obj["Subject"].ToString();
            AS = "";
            SO = "";

            con1.Close();
            cmd.Dispose();
            con1.Open();

            if (RadioButton1.Checked)
            {
                SO = RadioButton1.Text;
                Arr[Que_No] = 1;
            }
            else if (RadioButton2.Checked)
            {
                SO = RadioButton2.Text;
                Arr[Que_No] = 2;
            }
            else if (RadioButton3.Checked)
            {
                SO = RadioButton3.Text;
                Arr[Que_No] = 3;
            }
            else if (RadioButton4.Checked)
            {
                SO = RadioButton4.Text;
                Arr[Que_No] = 4;
            }

            if (SO == CO)
            {
                AS = "True";
            }
            else
            {
                AS = "False";
            }

            SqlDataAdapter sa1 = new SqlDataAdapter("select id from CET_Exam_AnswerSheet where Standard='" + std + "'and QuestionID='" + id + "'and RollNo = " + RollNo + "", con1);
            DataTable dt1 = new DataTable();
            sa1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                string strQuery1 = "Update CET_Exam_AnswerSheet set SelectedOption = '" + SO + "', AnswerStatus = '" + AS + "' where Standard='" + std + "'and QuestionID='" + id + "' and PaperID ='" + PID + "'";
                SqlCommand cmd1 = new SqlCommand(strQuery1, con1);

                cmd1.ExecuteNonQuery();
            }
            else
            {
                string strQuery = "insert into CET_Exam_AnswerSheet(ExamID,RollNo,Name,Standard,Subject,PaperID,QuestionID,Question,SelectedOption,CorrectOption,Explanation,AnswerStatus) values ('" + ExamID + "'," + RollNo + ",'" + FullName + "','" + std + "','" + Subject + "','" + PID + "'," + QID + ",'" + Question + "','" + SO + "','" + CO + "','" + Explanation + "','" + AS + "')";
                cmd = new SqlCommand(strQuery, con1);

                cmd.ExecuteNonQuery();

            }

            con1.Close();
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        if (SubClick != 0)
        {
            Button3_Click(sender, e);

            string connectionString1 = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con1 = new SqlConnection(connectionString1);
            con1.Open();

            SqlCommand cmd1 = new SqlCommand("select Total_Marks from CET_QuestionPaperInfo where Exam_ID = " + Convert.ToInt32(PID) + "", con1);

            var obj = cmd1.ExecuteReader();

            int Total = 0;
            if (obj.Read())
            {
                Total = Convert.ToInt32(obj["Total_Marks"]);
            }
            con1.Close();
            con1.Open();

            cmd1 = new SqlCommand("select count(*) from CET_Exam_AnswerSheet where Standard='" + std + "'and RollNo = " + RollNo + " and PaperID ='" + PID + "'", con1);

            int Solved = Convert.ToInt32(cmd1.ExecuteScalar());
            // int Solved = Convert.ToInt32(cmd1.ExecuteReader());

            int Correct = 0;
            if (Solved > 0)
            {
                cmd1 = new SqlCommand("select count(*) from CET_Exam_AnswerSheet where Standard='" + std + "'and RollNo = " + RollNo + " and PaperID ='" + PID + "' and AnswerStatus = 'True'", con1);
                Correct = Convert.ToInt32(cmd1.ExecuteScalar());
            }

            string fullname = name + " " + fname + " " + lname;
            SqlCommand cmd = new SqlCommand("insert into CET_StudentResult(Name,Standard,RollNo,ExamID,TotalQuestions,SolvedQuestions,TotalMarks,ObtainedMarks)values('" + fullname + "'," + std + "," + RollNo + "," + PID + "," + Total + "," + Solved + "," + Total + "," + Correct + ")", con1);

            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("select id from CET_StudentResult where Standard='" + std + "'and RollNo = " + RollNo + " and ExamID ='" + PID + "'", con1);
            int i = Convert.ToInt32(cmd.ExecuteScalar());

            ExamTime = 0;
            i1 = -1;
            i2 = -1;
            Response.Redirect("ResultForStudent.aspx?id=" + i);
        }
        else
        {
            ExamTime = 0;
            i1 = -1;
            i2 = -1;
            Response.Write("<script language='javascript'>window.alert('Not A Single Answer Is Answered \n You Can!!!'); window.location='Dashboard.aspx';</script>");
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {

    }
}