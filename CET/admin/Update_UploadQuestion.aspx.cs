using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Update_UploadQuestion : System.Web.UI.Page
{
    public string ServerValue = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if(Request.QueryString["Standard"] != null)
            {
                string Standard = Request.QueryString["Standard"];
                string Sub = Request.QueryString["Sub"];
                string CNo= Request.QueryString["CNo"];
                string CName = Request.QueryString["CName"];
                string QNo = Request.QueryString["QNo"];
                string QName= Request.QueryString["QName"];
                string OptionA = Request.QueryString["OptionA"];
                string OptionB = Request.QueryString["OptionB"];
                string OptionC = Request.QueryString["OptionC"];
                string OptionD = Request.QueryString["OptionD"];
                string C_Ans = Request.QueryString["C_Ans"];
                string Explanation = Request.QueryString["Explanation"];

                tb_Standard.Text = Standard;
                tb_Subject.Text = Sub;
                tb_ChapterNo.Text = CNo;
                tb_Chapter_Name.Text = CName;
                tb_Que_No.Text = QNo;
                tb_Question_Name.Text = QName;
                tb_Option_A.Text = OptionA;
                tb_Option_B.Text = OptionB;
                tb_Option_C.Text = OptionC;
                tb_Option_D.Text = OptionD;
                tb_Correct_Ans.Text = C_Ans;
                tb_Explaination.Text = Explanation;

            }
        }
    }


    protected void Update_Click(object sender, EventArgs e)
    {
        try
        {
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string Query = "Update CET_tbl_Question SET Chapter_No = " + tb_ChapterNo.Text + ", Chapter_Name = '" + tb_Chapter_Name.Text + "', Question_Name = '" + tb_Question_Name.Text + "', Option_A = '" + tb_Option_A.Text + "', Option_B = '" + tb_Option_B.Text + "', Option_C = '" + tb_Option_C.Text + "', Option_D = '" + tb_Option_D.Text + "', Correct_Ans = '" + tb_Correct_Ans.Text +"', Explanation = '" + tb_Explaination.Text +"' where Question_No = " + tb_Que_No.Text + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            Response.Write("<Script LANGUAGE = 'JavaScript'> alert ('Update Record Successfully')</Script>");
            Response.Redirect("Upload_Question_Master.aspx?");
        }
        catch (Exception ex)
        {

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}