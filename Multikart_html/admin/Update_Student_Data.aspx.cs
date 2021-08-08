using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Update_Student_Data : System.Web.UI.Page
{
    public string ServerValue = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if (Request.QueryString["Student_ID"] != null)
            {

           
                string StudentID = Request.QueryString["Student_ID"];
                string SFName = Request.QueryString["SFName"];
                string SMName = Request.QueryString["SMName"];
                string SLName = Request.QueryString["SLName"];
                string STD = Request.QueryString["STD"];
                string MNo = Request.QueryString["MNo"];
                string Address = Request.QueryString["Address"];

                tb_Stud_ID.Text = StudentID;
                tb_Stud_First_Name.Text = SFName;
                tb_Stud_Middle_Name.Text = SMName;
                tb_Stud_Last_Name.Text = SLName;
                tb_Standard.Text = STD;
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
        string Query = "Update CET_tbl_Student_Register SET Stud_First_Name = '" + tb_Stud_First_Name.Text + "', Stud_Middle_Name ='" + tb_Stud_Middle_Name.Text + "', Stud_Last_Name= '" + tb_Stud_Last_Name.Text + "', Standard = " + tb_Standard.Text + ", Mobile_No='" + tb_MoileNo.Text + "', Address= '" + tb_Address.Text + "' where Student_ID= " + tb_Stud_ID.Text + "";
        SqlCommand cmd = new SqlCommand(Query,con);
        cmd.ExecuteNonQuery();
        Response.Write("<Script LANGUAGE = 'JavaScript'> alert ('Update Successfully')</Script>");
        Response.Redirect("Student_Reg.aspx?");
        
    }
}