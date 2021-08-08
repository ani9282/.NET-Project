using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Update_Teacher_Reg_Data : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if(Request.QueryString["Teacher_ID"] != null)
            {
                string TeacherID = Request.QueryString["Teacher_ID"];
                string TFName = Request.QueryString["TFName"];
                string TMName = Request.QueryString["TMName"];
                string TLName = Request.QueryString["TLName"];
                string Subject = Request.QueryString["Subject"];
                string MNo = Request.QueryString["MNo"];
                string Address = Request.QueryString["Add"];

                tb_Teacher_ID.Text = TeacherID;
                tb_Teacher_First_Name.Text = TFName;
                tb_Teacher_Middle_Name.Text = TMName;
                tb_Teacher_Last_Name.Text = TLName;
                tb_Subject.Text = Subject;
                tb_MoileNo.Text = MNo;
                tb_Address.Text = Address;
            }
        }
    }

    protected void Update_Click(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        string Query = "Update CET_tbl_Teacher_Register SET Teacher_First_Name = '" + tb_Teacher_First_Name.Text + "', Teacher_Middle_Name ='" + tb_Teacher_Middle_Name.Text + "', Teacher_Last_Name= '" + tb_Teacher_Last_Name.Text + "', Subject = '" + tb_Subject.Text + "', Mobile_No='" + tb_MoileNo.Text + "', Address= '" + tb_Address.Text + "' where Teacher_ID= " + tb_Teacher_ID.Text + "";
        SqlCommand cmd = new SqlCommand(Query,con);
        cmd.ExecuteNonQuery();
        Response.Write("<Script LANGUAGE = 'JavaScript'> alert ('Update Successfully')</Script>");
        Response.Redirect("Teacher_Registration.aspx?");

    }
}