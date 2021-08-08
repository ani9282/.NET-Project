using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Teacher_Register_Form : System.Web.UI.Page
{

    int Auto_Increment()
    {
        int Cnt = 0;
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ToString();
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("Select Count(Teacher_ID) from CET_tbl_Teacher_Register");
        cmd.Connection = con;
        Cnt = Convert.ToInt32(cmd.ExecuteScalar());
        if (Cnt > 0)
        {
            cmd.CommandText = "Select Max(Teacher_ID) from CET_tbl_Teacher_Register";
            cmd.Connection = con;
            Cnt = Convert.ToInt32(cmd.ExecuteScalar());
            Cnt += 1;
        }
        else
        {
            Cnt += 1;
        }
        cmd.Dispose();
        con.Close();
        return Cnt;

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        tb_Teacher_ID.Text = Convert.ToString(Auto_Increment());

        if (!IsPostBack)
        {
            GetData();
        }


        //Subject PageLoding Code 
        try
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Distinct(Subject) from CET_Chapter", con);
            cmd.Connection = con;
            var obj = cmd.ExecuteReader();
            while (obj.Read())
            {
                DDL_Subject.Items.Add(obj.GetString(obj.GetOrdinal("Subject")));
            }
            obj.Dispose();
        }
        catch (Exception ex)
        {

        }
    }

    private void GetData()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ToString();
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tbl_Teacher_Register", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        grdView.DataSource = dt;
        grdView.DataBind();


    }

    //Button Save Coding 
    protected void Save_Click(object sender, EventArgs e)
    {
        Random Password = new Random();
        int NewPassword = Password.Next(1000, 10000);
        try
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (tb_Teacher_ID.Text != "" && tb_Teacher_First_Name.Text != "" && tb_Teacher_Middle_Name.Text != "" && tb_Teacher_Last_Name.Text != "" && DDL_Subject.Text != "" && tb_MoileNo.Text != "" && tb_Address.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert into CET_tbl_Teacher_Register Values(" + tb_Teacher_ID.Text + ", '" + tb_Teacher_First_Name.Text + "', '" + tb_Teacher_Middle_Name.Text + "', '" + tb_Teacher_Last_Name.Text + "', '" + DDL_Subject.Text + "', '" + tb_MoileNo.Text + "', '" + tb_Address.Text + "','" + NewPassword + "')");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Response.Write("<script LANGUAGE= 'JavaScript' >alert ('Record Save Successfully')</Script>");
                clear_Control();
                GetData();
            }
            else
            {
                Response.Write("<script LANGUAGE= 'JavaScript' >alert ('First Fill All The Field')</Script>");
            }

        }
        catch (Exception ex)
        {

        }

    }

    //Data Clear Control Code
    private void clear_Control()
    {
        tb_Teacher_ID.Text = Convert.ToString(Auto_Increment());
        tb_Teacher_First_Name.Text = "";
        tb_Teacher_Middle_Name.Text = "";
        tb_Teacher_Last_Name.Text = "";
        DDL_Subject.SelectedIndex = 0;
        tb_MoileNo.Text = "";
        tb_Address.Text = "";


    }


    //GridView Edit And Delete CommandName code
    protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "lnkbtnEdit")
        {
            string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
            string TeacherID = commandArgs[0];
            string TFName = commandArgs[1];
            string TMName = commandArgs[2];
            string TLName = commandArgs[3];
            string Subject = commandArgs[4];
            string MNo = commandArgs[5];
            string Add = commandArgs[6];

            Response.Redirect("Update_Teacher_Reg_Data.aspx?Teacher_ID=" + TeacherID + "&TFName=" + TFName + "&TMName=" + TMName + "&TLName=" + TLName + "&Subject=" + Subject + "&MNo=" + MNo + "&Add=" + Add);
            GetData();
        }
        if (e.CommandName == "lnkbtnDelete")
        {
            string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
            string TeacherID = commandArgs[0];
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete CET_tbl_Teacher_Register where Teacher_ID= " + Convert.ToInt32(TeacherID) + "");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Response.Write("<script LANGUAGE= 'JavaScript' >alert ('Record Delete Successfully')</Script>");
                GetData();
                con.Close();

            }
            catch (Exception ex)
            {

            }

        }
    }

    protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdView.PageIndex = e.NewPageIndex;
        this.GetData();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}