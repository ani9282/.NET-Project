using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Student_Registeration_Form : System.Web.UI.Page
{
    int Auto_Increment()
    {
        int cnt = 0;
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "Select Count(Student_ID) from CET_tbl_Student_Register";
        cmd1.Connection = con;
        cnt = Convert.ToInt32(cmd1.ExecuteScalar());

        if (cnt > 0)
        {
            cmd1.CommandText = "Select Max(Student_ID) from CET_tbl_Student_Register";
            cmd1.Connection = con;
            cnt = Convert.ToInt32(cmd1.ExecuteScalar());
            cnt = cnt + 1;
        }
        else
        {
            cnt = cnt + 1;
        }
        cmd1.Dispose();
        con.Close();
        return cnt;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        getdata();
        ///AutoIncrement Code
        tb_Stud_ID.Text = Convert.ToString(Auto_Increment());

        if (!IsPostBack)
        {
            getdata();
        }

    }
    public void getdata()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tbl_Student_Register", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        grdView.DataSource = dt;
        grdView.DataBind();
    }


    /// Gridview Edit And Delete Code
    protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "lnkbtnEdit")
        {

            string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
            string Student_ID = commandArgs[0];
            string SFName = commandArgs[1];
            string SMName = commandArgs[2];
            string SLName = commandArgs[3];
            string STD = commandArgs[4];
            string MNo = commandArgs[5];
            string Address = commandArgs[6];

            Response.Redirect("Update_Student_Data.aspx?Student_ID=" + Student_ID + "&SFName=" + SFName + "&SMName=" + SMName + "&SLName=" + SLName + "&STD=" + STD + "&MNo=" + MNo + "&Address=" + Address);
            getdata();



        }
        if (e.CommandName == "lnkbtnDelete")
        {
            try
            {
                //var StudID = Int32.Parse(e.CommandArgument);
                string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
                string StudentID = commandArgs[0];
                string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from CET_tbl_Student_Register where Student_ID = " + Convert.ToInt32(StudentID) + "", con);
                cmd.ExecuteNonQuery();
                Response.Write("<Script LANGUAGE ='JavaScript'>alert ('Record Deleted Successfully')</Script>");
                getdata();
                con.Close();
            }
            catch (Exception ex)
            {

            }


        }
    }

    //Data Save Button Coding
    protected void Save_Click(object sender, EventArgs e)
    {
        Random Password = new Random();
        int NewPassword = Password.Next(1000, 10000);
        try
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            String strQuery = "insert into CET_tbl_Student_Register (Student_ID,Stud_First_Name,Stud_Middle_Name,Stud_Last_Name,Standard,Mobile_No,Address,Password) values (" + tb_Stud_ID.Text + ",'" + tb_Stud_First_Name.Text + "', '" + tb_Stud_Middle_Name.Text + "', '" + tb_Stud_Last_Name.Text + "'," + tb_Standard.Text + ",'" + tb_MoileNo.Text + "', '" + tb_Address.Text + "', '" + NewPassword + "' )";
            SqlCommand cmd = new SqlCommand(strQuery);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE= 'JavaScript' >alert ('Record Save Successfully')</Script>");

            Clear_Controls();
            getdata();

        }
        catch (Exception ex)
        {

        }

    }

    //TextBox ClearControls Function 
    private void Clear_Controls()
    {
        tb_Stud_ID.Text = Convert.ToString(Auto_Increment());
        tb_Stud_First_Name.Text = "";
        tb_Stud_Middle_Name.Text = "";
        tb_Stud_Last_Name.Text = "";
        tb_Standard.Text = "";
        tb_MoileNo.Text = "";
        tb_Address.Text = "";
    }


    protected void Button1_Click(object sender,EventArgs e)
    {

    }
}
