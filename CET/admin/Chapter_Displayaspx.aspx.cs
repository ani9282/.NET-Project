using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Chapter_Displayaspx : System.Web.UI.Page
{
    /*
    int AutoIncrement()
    {
        int Cnt = 0;
        //string  ID = tb_Q_PID.Text;
        // string ID = this.Request.Form["Chapter_ID"];
        //var name = this.Request.Form["ChapterNumber"];
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("Select Count(Ques_P_ID) from DCET_tbl_QP", con);
        Cnt = Convert.ToInt32(cmd.ExecuteScalar());
        if (Cnt > 0)
        {
            SqlCommand cmd1 = new SqlCommand("Select Max(Ques_P_ID) from DCET_tbl_QP", con);
            Cnt = Convert.ToInt32(cmd1.ExecuteScalar());
            Cnt += 101;
        }
        else
        {
            Cnt += 101;
        }

        return Cnt;
    }
    */
    protected void Page_Load(object sender, EventArgs e)
    {
        // tb_Q_PID.Text = Convert.ToString(AutoIncrement());
        if (!IsPostBack)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand(Query, con);
            // cmd.Connection = con;
            con.Open();
            DataTable dt = new DataTable();

            tb_Standard.Text = Session["Std"].ToString();
            tb_T_Marks.Text = Session["TMarks"].ToString();
            tb_Time.Text = Session["Time"].ToString();

            if (Session["Phy"] != null)
            {
                lbl_Physics.Visible = true;
                tb_Physics.Visible = true;
                lbl_Physics.Text = Session["Phy"].ToString();
                tb_Physics.Text = Session["MPhy"].ToString();
                //  "Select ChapterName From Tablename Where Std = " +tb+ "";
                string Query1 = "Select ChapterName from CET_Chapter Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Physics.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(Query1, con);
                sda1.Fill(dt);
            }
            else
            {
                lbl_Physics.Visible = false;
                tb_Physics.Visible = false;
            }

            if (Session["chem"] != null)
            {
                lbl_Chemistry.Visible = true;
                tb_Chemistry.Visible = true;
                lbl_Chemistry.Text = Session["Chem"].ToString();
                tb_Chemistry.Text = Session["MChem"].ToString();
                //Filldgv("Select * from CET_tblSubject");
                string Query2 = "Select ChapterName from CET_Chapter Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Chemistry.Text + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(Query2, con);
                sda2.Fill(dt);
            }
            else
            {
                lbl_Chemistry.Visible = false;
                tb_Chemistry.Visible = false;
            }

            if (Session["Math"] != null)
            {
                lbl_Maths.Visible = true;
                tb_Maths.Visible = true;
                lbl_Maths.Text = Session["Math"].ToString();
                tb_Maths.Text = Session["MMaths"].ToString();
                string Query3 = "Select  ChapterName  from CET_Chapter Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Maths.Text + "'";
                SqlDataAdapter sda3 = new SqlDataAdapter(Query3, con);
                sda3.Fill(dt);
            }
            else
            {
                lbl_Maths.Visible = false;
                tb_Maths.Visible = false;
            }

            if (Session["Bio"] != null)
            {
                lbl_Biology.Visible = true;
                tb_Biology.Visible = true;
                lbl_Biology.Text = Session["Bio"].ToString();
                tb_Biology.Text = Session["MBio"].ToString();
                string Query4 = "Select ChapterName from CET_Chapter Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Biology.Text + "'";
                SqlDataAdapter sda4 = new SqlDataAdapter(Query4, con);
                sda4.Fill(dt);
            }
            else
            {
                lbl_Biology.Visible = false;
                tb_Biology.Visible = false;
            }
            /*
            if (Session["Phy"] != null)
            {
                lbl_Physics.Visible = true;
                tb_Physics.Visible = true;
                lbl_Physics.Text = Session["Phy"].ToString();
                tb_Physics.Text = Session["MPhy"].ToString();
                //  "Select ChapterName From Tablename Where Std = " +tb+ "";
                string Query1 = "Select Chapter_Name,Q_ID from CET_tbl_Question Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Physics.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(Query1, con);
                sda1.Fill(dt);
            }
            else
            {
                lbl_Physics.Visible = false;
                tb_Physics.Visible = false;
            }

            if (Session["chem"] != null)
            {
                lbl_Chemistry.Visible = true;
                tb_Chemistry.Visible = true;
                lbl_Chemistry.Text = Session["Chem"].ToString();
                tb_Chemistry.Text = Session["MChem"].ToString();
                //Filldgv("Select * from CET_tblSubject");
                string Query2 = "Select Chapter_Name,Q_ID from CET_tbl_Question Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Chemistry.Text + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(Query2, con);
                sda2.Fill(dt);
            }
            else
            {
                lbl_Chemistry.Visible = false;
                tb_Chemistry.Visible = false;
            }

            if (Session["Math"] != null)
            {
                lbl_Maths.Visible = true;
                tb_Maths.Visible = true;
                lbl_Maths.Text = Session["Math"].ToString();
                tb_Maths.Text = Session["MMaths"].ToString();
                string Query3 = "Select Chapter_Name,Q_ID from CET_tbl_Question Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Maths.Text + "'";
                SqlDataAdapter sda3 = new SqlDataAdapter(Query3, con);
                sda3.Fill(dt);
            }
            else
            {
                lbl_Maths.Visible = false;
                tb_Maths.Visible = false;
            }

            if (Session["Bio"] != null)
            {
                lbl_Biology.Visible = true;
                tb_Biology.Visible = true;
                lbl_Biology.Text = Session["Bio"].ToString();
                tb_Biology.Text = Session["MBio"].ToString();
                string Query4 = "Select Chapter_Name,Q_ID from CET_tbl_Question Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Biology.Text + "'";
                SqlDataAdapter sda4 = new SqlDataAdapter(Query4, con);
                sda4.Fill(dt);
            }
            else
            {
                lbl_Biology.Visible = false;
                tb_Biology.Visible = false;
            }*/
            GDV_Chapter_Show.DataSource = dt;
            GDV_Chapter_Show.DataBind();
            con.Close();

        }
        Session.Abandon();
    }

    protected void btn_View_Click(object sender,EventArgs e)
    {
       /*try
        {
            string TNQues = "";
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into DCET_tbl_QP values(" + tb_Q_PID.Text + ", '" + tb_Time.Text + "','" + TNQues + "', )", con);
        }
        catch(Exception ex)
        {

        }
        Session["QP_ID"] = tb_Q_PID.Text;
        Session["TMarks"] = tb_T_Marks.Text;
        Session["Time"] = tb_Time.Text;*/
        
        
        foreach (GridViewRow row in GDV_Chapter_Show.Rows)
        {
            if ((row.FindControl("CHKB_Select") as CheckBox).Checked)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                //int Number = Convert.ToInt32((row.Cells[3].FindControl("lbl_Chapter_No") as Label).Text);
                string CName = (row.Cells[1].FindControl("lbl_CName") as Label).Text;
                //string Subject = 
                string Ques = "";
                
                SqlCommand cmd = new SqlCommand("Select Distinct(Question_Name) From CET_tbl_Question Where Standard =" + tb_Standard.Text + " And Chapter_Name = '" + CName + "'", con);
                //SqlCommand cmd = new SqlCommand("Select Distinct(Question_Name) From CET_tbl_Question Where Subject =" + tb_Standard.Text + " And Subject = '" + CName + "'", con);
                var Obj = cmd.ExecuteReader();
                cmd.Dispose();

                if (Obj.Read())
                {
                    Ques = Obj["Question_Name"].ToString();
                    SqlCommand cmd1 = new SqlCommand("Insert Into CET_Tempory_tbl Values(" + tb_Standard.Text + ",'" + CName + "','" + Ques + "')", con);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    Obj.Close();
                }

                /*SqlCommand cmd1 = new SqlCommand("Insert Into CET_Tempory_tbl Values(" + tb_Standard.Text + ",'" + CName + "','" + Ques + "')", con);
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();*/

                con.Close();
            }
        }

       // Session["Total_Marks"] = tb_T_Marks.Text;
        //Session["Total_Time"] = tb_Time.Text;

        Response.Redirect("QuestionShow.aspx?");

    }

    protected void tb_T_Ques_TextChanged(object sender, EventArgs e)
    {

    }
}