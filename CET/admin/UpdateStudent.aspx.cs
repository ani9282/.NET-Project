using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class UpdateStudent : System.Web.UI.Page
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
        if (!IsPostBack)
        {
            GetData();
        }

       StudentID = Request.QueryString["Student_ID"];
         SFName = Request.QueryString["SFName"];
        SMName = Request.QueryString["SMName"];
        SLName = Request.QueryString["SLName"];
        STD = Request.QueryString["STD"];
        MNo = Request.QueryString["MNo"];
        Address = Request.QueryString["Address"];
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


        
     string Query = "Update CET_tbl_Student_Register SET Stud_First_Name = '" + Name + "', Stud_Middle_Name ='" + MName + "', Stud_Last_Name= '" + LName + "', Standard = " + std + ", Mobile_No='" + mobile+ "', Address= '" + address+ "' where Student_ID= " + studentid + "";
     SqlCommand cmd = new SqlCommand(Query, con);
     cmd.ExecuteNonQuery();
        Response.Write("<script LANGUAGE= 'JavaScript' >alert ('Record Update Successfully')</Script>"); 
    }
    private void GetData()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ToString();
        System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString);
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
}