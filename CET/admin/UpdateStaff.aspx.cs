using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_UpdateStaff : System.Web.UI.Page
{
    public String StudentID = string.Empty;
    public String SFName = string.Empty;
    public String SMName = string.Empty;
    public String SLName = string.Empty;
    public String STD = string.Empty;
    public String MNo = string.Empty;
    public String Address = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        StudentID = Request.QueryString["Teacher_ID"];
        SFName = Request.QueryString["TFName"];
        SMName = Request.QueryString["TMName"];
        SLName = Request.QueryString["TLName"];
        STD = Request.QueryString["Subject"];
        MNo = Request.QueryString["MNo"];
        Address = Request.QueryString["Add"];
        GetData();
        if (!IsPostBack)
        {

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
    private void GetData()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ToString();
        System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tbl_Teacher_Register", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        grdView.DataSource = dt;
        grdView.DataBind();


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ToString();
        System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        String Name = Request.Form["fname"];
        String MName = Request.Form["mname"];
        String LName = Request.Form["lname"];
        String std = DropDownList1.Text;
        String mobile = Request.Form["email"];
        String address = Request.Form["address"];
        String studentid = Request.Form["id"];



        string Query = "Update CET_tbl_Teacher_Register SET Teacher_First_Name = '" + Name + "', Teacher_Middle_Name ='" + MName + "', Teacher_Last_Name= '" + LName + "', Subject = '" + std + "', Mobile_No='" + mobile + "', Address= '" + address + "' where Teacher_ID= " + studentid+ "";
        SqlCommand cmd = new SqlCommand(Query, con);
        cmd.ExecuteNonQuery();
        Response.Write("<Script LANGUAGE = 'JavaScript'> alert ('Update Successfully')</Script>");
        
    }
}