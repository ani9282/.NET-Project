using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class admin_StudRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData();
        }

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    private void GetData()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ToString();
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tbl_Student_Register", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        grdView.DataSource = dt;
        grdView.DataBind();


    }
    protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdView.PageIndex = e.NewPageIndex;
        this.GetData();
    }
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

            Response.Redirect("UpdateStudent.aspx?Student_ID=" + TeacherID + "&SFName=" + TFName + "&SMName=" + TMName + "&SLName=" + TLName + "&STD=" + Subject + "&MNo=" + MNo + "&Address=" + Add);
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
                SqlCommand cmd = new SqlCommand("Delete CET_tbl_Student_Register where Teacher_ID= " + Convert.ToInt32(TeacherID) + "");
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int cnt = 0;
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
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

        Random Password = new Random();
        int NewPassword = Password.Next(1000, 10000);


            String Name = Request.Form["fname"];
            String MName = Request.Form["mname"];
            String LName = Request.Form["lname"];
            String std = DropDownList1.Text;
            String mobile= Request.Form["email"];
            String address = Request.Form["address"];
            String strQuery = "insert into CET_tbl_Student_Register (Student_ID,Stud_First_Name,Stud_Middle_Name,Stud_Last_Name,Standard,Mobile_No,Address,Password) values (" + cnt + ",'" + Name+ "', '" + MName + "', '" + LName + "'," + std + ",'" + mobile + "', '" + address + "', '" + NewPassword + "' )";
              SqlCommand cmd = new SqlCommand(strQuery);
             cmd.Connection = con;
           cmd.ExecuteNonQuery();

            Response.Write("<script LANGUAGE= 'JavaScript' >alert ('Record Save Successfully')</Script>");

            //Clear_Controls();
          //  getdata();

        }
        catch (Exception ex)
        {

        }







    }
}

