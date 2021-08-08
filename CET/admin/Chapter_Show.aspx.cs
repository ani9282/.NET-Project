using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class admin_Chapter_Show : System.Web.UI.Page
{
    public string ServerValue = String.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
            //SqlCommand cmd = new SqlCommand(Query, con);
            // cmd.Connection = con;
            con.Open();
            DataTable dt = new DataTable();

            tb_Standard.Text = Session["Std"].ToString();
            tb_T_Marks.Text = Session["TMarks"].ToString();
            tb_Time.Text = Session["Time"].ToString();
            
            if (Session["Phy"]!= null)
            {
                lbl_Physics.Visible = true;
                tb_Physics.Visible = true;
                lbl_Physics.Text = Session["Phy"].ToString();
                tb_Physics.Text = Session["MPhy"].ToString();
                //  "Select ChapterName From Tablename Where Std = " +tb+ "";
                string Query1= "Select ChapterName from CET_Chapter Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Physics.Text + "'";
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
                string Query2= "Select ChapterName from CET_Chapter Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Chemistry.Text + "'";
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
               string Query3= "Select ChapterName from CET_Chapter Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Maths.Text + "'";
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
                string Query4= "Select ChapterName from CET_Chapter Where Standard = " + tb_Standard.Text + " And Subject ='" + lbl_Biology.Text + "'";
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

    void Filldgv(string Query)
    {
        System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
        //SqlCommand cmd = new SqlCommand(Query, con);
        // cmd.Connection = con;
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter(Query, con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        GDV_Chapter_Show.DataSource = dt;
        GDV_Chapter_Show.DataBind();
        con.Close();
    }
    /*
    bool CmpMarks()
    {
        //bool bRet = false;
        if (tb_Physics.Visible == true && tb_Chemistry.Visible == true)
        {
            if ()
            {
                return (tb_TMarks.Text == (tb_Physics.Text + tb_Chemistry.Text));
            } 
           
        }
    }*/

    protected void Btn_View_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow row in GDV_Chapter_Show.Rows)
        {
            if ((row.FindControl("CHKB_Select") as CheckBox).Checked)
            {
                int Number = Convert.ToInt32((row.Cells[3].FindControl("lbl_Chapter_No") as Label).Text);

                System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Temperoy_CET_Chapter_Number Values(" + Number + ")", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            Session["Total_Marks"] = tb_T_Marks.Text;
            Session["Total_Time"] = tb_Time.Text;

            Response.Redirect("Quetion_Show.aspx?");
        }


    }
}