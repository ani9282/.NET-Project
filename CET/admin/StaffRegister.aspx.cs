using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_StaffRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

        if (!IsPostBack)
        {
            GetData();
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);



            con.Open();

            string com = "Select * from CET_tblSubject";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();


            adpt.Fill(dt);



            DropDownList1.DataSource = dt;

            DropDownList1.DataTextField = "Subject_Name";
            DropDownList1.DataValueField = "Subject_Name";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("Select Subject", "Select Subject"));
            DropDownList1.SelectedIndex = 0;
        }

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

            Response.Redirect("UpdateStaff.aspx?Teacher_ID=" + TeacherID + "&TFName=" + TFName + "&TMName=" + TMName + "&TLName=" + TLName + "&Subject=" + Subject + "&MNo=" + MNo + "&Add=" + Add);
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

    protected void Button1_Click(object sender, EventArgs e)
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




        Random Password = new Random();
        int NewPassword = Password.Next(1000, 10000);
        try
        {
            
            String Name = Request.Form["fname"];
            String MName = Request.Form["mname"];
            String LName = Request.Form["lname"];
            String std = DropDownList1.Text;
            String mobile = Request.Form["email"];
            String address = Request.Form["address"];


            SqlCommand cmd1 = new SqlCommand("Insert into CET_tbl_Teacher_Register Values(" + Cnt + ", '" + Name+ "', '" + MName + "', '" + LName + "', '" + std + "', '" + mobile + "', '" + address + "','" + NewPassword + "')");
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();

            string Number = mobile;
            
            string Message = "Welcome to SPKVT CET CELL Your User Name is :"+ mobile + "Password is "+NewPassword;

            WebClient client = new WebClient();
            String user = "rahulecs";
            String password = "rahulecs";
            String number = "91" + Number;
            String SID = "ENTERP";


            string baseurl = "http://5.189.153.48:8080/vendorsms/pushsms.aspx?user=" + user + "&password=" + password + "&msisdn=" + number + "&sid=" + SID + "&msg=" + Message + "&fl=0&dc=8&gwid=2";
            Stream data = client.OpenRead(baseurl);

            StreamReader reader = new StreamReader(data);
            string ResponseID = reader.ReadToEnd();
            Response.Write("<script LANGUAGE= 'JavaScript' >alert ('Record Save Successfully')</Script>");
              //  clear_Control();
             //   GetData();
            
           

        }
        catch (Exception ex)
        {

        }

    }
}