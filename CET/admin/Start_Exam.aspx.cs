using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Start_Exam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ////CheckBox List Subject Loading Code
        if (!IsPostBack)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string Query = "Select * from CET_tblSubject";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CheckList_Subject.DataTextField = "Subject_Name";
            CheckList_Subject.DataValueField = "Subject_ID";
            CheckList_Subject.DataSource = dt;
            CheckList_Subject.DataBind();
            con.Close();
            /*
            tb_Physics.Text = "0";
            tb_Chemistry.Text = "0";
            tb_Maths.Text = "0";
            tb_Biology.Text = "0";*/
        } 

    }
    protected void CheckList_Subject_SelectedIndexChanged(object sender, EventArgs e)
    {

        for (int i = 0; i < CheckList_Subject.Items.Count; i++)
        {
            if (CheckList_Subject.Items[0].Selected)
            {
                lbl_Physics.Visible = true;
                lbl_Physics.Text = CheckList_Subject.Items[0].Text;
                tb_Physics.Visible = true;
            }
            else
            {
                    lbl_Physics.Visible = false;

                    tb_Physics.Visible = false;
                    tb_Physics.Text = "";

            }
            if ((CheckList_Subject.Items[1].Selected))
            { 
                lbl_Chemistry.Visible = true;
                lbl_Chemistry.Text = CheckList_Subject.Items[1].Text;
                tb_Chemistry.Visible = true; 
            }
            else
            {
                    lbl_Chemistry.Visible = false;

                    tb_Chemistry.Visible = false;
                    tb_Chemistry.Text = "";
                  
            }
            if(CheckList_Subject.Items[2].Selected)
            { 
                lbl_Maths.Visible = true;
                lbl_Maths.Text = CheckList_Subject.Items[2].Text;
                tb_Maths.Visible = true;
            }
            else
            {
                lbl_Maths.Visible = false;

                tb_Maths.Visible = false;
                tb_Maths.Text = "";
            }

            if (CheckList_Subject.Items[3].Selected)
            { 
                lbl_Biology.Visible = true;
                lbl_Biology.Text = CheckList_Subject.Items[3].Text ;
                tb_Biology.Visible= true; 
            }
            else
            {
                lbl_Biology.Visible = false;

                tb_Biology.Visible = false;
                tb_Biology.Text = "";
            }      
        }    
       
    }

    
    protected void Btn_View_Click(object sender, EventArgs e)
    {

        // int Ret = Convert.ToInt32(tb_Physics.Text + tb_Chemistry.Text + tb_Biology.Text + tb_Maths.Text);
        int Ret = 0;
        if (tb_Physics.Visible == true)
        {
            Ret += Convert.ToInt32(tb_Physics.Text);
        }
        if (tb_Chemistry.Visible == true)
        {
            Ret += Convert.ToInt32(tb_Chemistry.Text);
        }
        if (tb_Maths.Visible == true)
        {
            Ret += Convert.ToInt32(tb_Maths.Text);
        }
        if (tb_Biology.Visible == true)
        {
            Ret += Convert.ToInt32(tb_Biology.Text);
        }
        //int Ret2 = Convert.ToInt32(tb_TMarks.Text);
        if  (Ret == Convert.ToInt32(tb_TMarks.Text))
        {
            Session["Std"] = DDL_Standard.Text;
            Session["TMarks"] = tb_TMarks.Text;
            Session["MPhy"] = tb_Physics.Text;
            Session["MChem"] = tb_Chemistry.Text;
            Session["MMaths"] = tb_Maths.Text;
            Session["MBio"] = tb_Biology.Text;
            Session["Time"] = tb_Time.Text;

            var Sub1 = CheckList_Subject.Items[0].Selected;
            var Sub2 = CheckList_Subject.Items[1].Selected;
            var Sub3 = CheckList_Subject.Items[2].Selected;
            var Sub4 = CheckList_Subject.Items[3].Selected;

            if (Sub1 == true)
            {
                Session["Phy"] = lbl_Physics.Text;
            }
            if (Sub2 == true)
            {
                Session["chem"] = lbl_Chemistry.Text;
            }
            if (Sub3 == true)
            {
                Session["Math"] = lbl_Maths.Text;
            }
            if (Sub4 == true)
            {
                Session["Bio"] = lbl_Biology.Text;
            }

            //Response.Redirect("Chapter_show.aspx?");
            Response.Redirect("Chapter_Displayaspx.aspx?");

        }
        else
        {
            Response.Write("<script LANGUAGE= 'JavaScript' >alert (' Not Mathched Total Marks ...ReEnter Correct Marks..!!')</Script>");
        }




        /*
            if (lbl_Physics.Visible == true)
            {
                Session["Phy"] = lbl_Physics.Text;
            }
            if (lbl_Chemistry.Visible == true)
            {
                Session["chem"] = lbl_Chemistry.Text;
            }
            if (lbl_Maths.Visible == true)
            {
                Session["Math"] = lbl_Maths.Text;
            }
            if (lbl_Biology.Visible == true)
            {
                Session["Bio"] = lbl_Biology.Text;
            }
      */


       
        //tb_Subject.Text = Session["Phy"].ToString();



    }
    protected void btn_Calculation_Click(object sender, EventArgs e)
    {
       
         

    }
}