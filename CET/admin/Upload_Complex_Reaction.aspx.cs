using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;


public partial class admin_Upload_Complex_Reaction : System.Web.UI.Page
{


    int Auto_Increment(string cmd1, string str)
    {

        int cnt = 0;
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = cmd1;
        cmd.Connection = con;
        cnt = Convert.ToInt32(cmd.ExecuteScalar());

        if (cnt > 0)
        {
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = str;
            cmd2.Connection = con;
            cnt = Convert.ToInt32(cmd2.ExecuteScalar());
            cnt = cnt + 1;
        }
        else
        {
            cnt = cnt + 1;
        }
        cmd.Dispose();
        con.Close();
        return cnt;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData();

            //AutoIncrement Question Number Code
            // tb_Que_No.Text = Convert.ToString(Auto_Increment());

            ///Standard And Subject Loding Code
            tb_Subject.Text = Session["Phy1"].ToString();
            tb_Standard.Text = Session["Std1"].ToString();

            ///DorpDownList Subject Loding Code
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Distinct(ChapterName) from CET_Chapter where Standard = " + tb_Standard.Text + " And Subject = '" + tb_Subject.Text + "' ", con);
                var obj = cmd.ExecuteReader();


                while (obj.Read())
                {
                    dropdownlist_ChapterName.Items.Add(obj.GetString(obj.GetOrdinal("ChapterName")));
                }
                obj.Dispose();



                //tb_Que_No.Text = Convert.ToString(Auto_Increment("Select Count(Question_No) from CET_tbl_Question where Standard = " + tb_Standard.Text + "And Subject = '" + tb_Subject.Text + "'And ChapterName = '" + dropdownlist_ChapterName.Text + "'", "Select Max(Question_No) from CET_tbl_Question where Standard = " + tb_Standard.Text + "And Subject = '" + tb_Subject.Text + "'And ChapterName = '" + dropdownlist_ChapterName.Text + "'"));

            }
            catch (Exception ex)
            {

            }

        }
    }

    private void GetData()
    {
        try
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from CET_tbl_Question", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //grdView.DataSource = dt;
           // grdView.DataBind();
        }
        catch (Exception ex)
        {

            //throw;
        }

    }





    protected void dropdownlist_ChapterName_SelectedIndexChanged(object sender, EventArgs e)
    {
        //dropdownlist_ChapterName.Items.Clear();
        try
        {

            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Chapter_ID from CET_Chapter where Standard = " + tb_Standard.Text + " And Subject = '" + tb_Subject.Text + "' And ChapterName = '" + dropdownlist_ChapterName.Text + "' ", con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_ChapterNo.Text = (obj["Chapter_ID"].ToString());
            }

            obj.Dispose();

            tb_Que_No.Text = Convert.ToString(Auto_Increment("Select Count(reaction_no) from CETUpload_Reaction where standard = " + tb_Standard.Text + "And subject = '" + tb_Subject.Text + "'And Chapter_Name = '" + dropdownlist_ChapterName.Text + "'", "Select Max(Question_No) from CET_tbl_Question where Standard = " + tb_Standard.Text + "And Subject = '" + tb_Subject.Text + "'And Chapter_Name = '" + dropdownlist_ChapterName.Text + "'"));


        }
        catch (Exception ex)
        {

        }



    }

    protected void tb_ChapterNo_OnTextChanged(object sender, EventArgs e)
    {


        try
        {
            dropdownlist_ChapterName.Items.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Distinct(ChapterName) from CET_Chapter where Standard = " + tb_Standard.Text + " And Subject = '" + tb_Subject.Text + "' ", con);
            var obj = cmd.ExecuteReader();

            while (obj.Read())
            {
                dropdownlist_ChapterName.Items.Add(obj.GetString(obj.GetOrdinal("ChapterName")));
            }
            obj.Dispose();


            //tb_Que_No.Text = Convert.ToString(Auto_Increment("Select Count(Question_No) from CET_tbl_Question where Standard = " + tb_Standard.Text + "And Subject = '" + tb_Subject.Text + "'And ChapterName = '" + dropdownlist_ChapterName.Text + "'", "Select Max(Question_No) from CET_tbl_Question where Standard = " + tb_Standard.Text + "And Subject = '" + tb_Subject.Text + "'And ChapterName = '" + dropdownlist_ChapterName.Text + "'"));

        }
        catch (Exception ex)
        {

        }



    }

    protected void dropdownlist_ChapterName_OnTextChanged(object sender, EventArgs e)
    {
        //dropdownlist_ChapterName.Items.Clear();
        /*
        if (dropdownlist_ChapterName.Text != "")
        {
            

            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Distinct(ChapterName) from CET_Chapter where Standard = " + tb_Standard.Text + " And Subject = '" + tb_Subject.Text + "' ", con);
            var obj = cmd.ExecuteReader();

            while (obj.Read())
            {
                dropdownlist_ChapterName.Items.Add(obj.GetString(obj.GetOrdinal("ChapterName")));
            }
            obj.Dispose();
        }*/
    }


    protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "lnkbtnEdit")
        {
            string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
            string Standard = commandArgs[0];
            string Sub = commandArgs[1];
            string CNo = commandArgs[2];
            string CName = commandArgs[3];
            string QNo = commandArgs[4];
            string QName = commandArgs[5];
            string OptionA = commandArgs[6];
            string OptionB = commandArgs[7];
            string OptionC = commandArgs[8];
            string OptionD = commandArgs[9];
            string C_Ans = commandArgs[10];
            string Explanation = commandArgs[11];

            Response.Redirect("Update_UploadQuestion.aspx?Standard=" + Standard + " &Sub=" + Sub + " &CNo=" + CNo + " &CName=" + CName + " &QNo=" + QNo + " &QName=" + QName + " &OptionA=" + OptionA + " &OptionB=" + OptionB + " &OptionC=" + OptionC + " &OptionD=" + OptionD + " &C_Ans=" + C_Ans + " &Explanation=" + Explanation);
            GetData();

        }

        if (e.CommandName == "lnkbtnDelete")
        {
            string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
            string Standard = commandArgs[0];
            string Sub = commandArgs[1];
            string CNo = commandArgs[2];
            string CName = commandArgs[3];
            string QNo = commandArgs[4];
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                String Query = "Delete CET_tbl_Question where Standard = " + Convert.ToInt32(Standard) + " And Subject = '" + Sub + "' And Chapter_No = " + Convert.ToInt32(CNo) + " And Chapter_Name = '" + CName + "' And Question_No=" + Convert.ToInt32(QNo) + "";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script LANGUAGE= 'JavaScript' >alert ('Record Delete Successfully')</Script>");
                GetData();
                cmd.Dispose();
                con.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {

            }
        }
    }

    public static string Encrypt(string input, string key)
    {
        byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
        TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
        tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
        tripleDES.Mode = CipherMode.ECB;
        tripleDES.Padding = PaddingMode.PKCS7;
        ICryptoTransform cTransform = tripleDES.CreateEncryptor();
        byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
        tripleDES.Clear();
        return Convert.ToBase64String(resultArray, 0, resultArray.Length);
    }
    public static string Decrypt(string input, string key)
    {
        byte[] inputArray = Convert.FromBase64String(input);
        TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
        tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
        tripleDES.Mode = CipherMode.ECB;
        tripleDES.Padding = PaddingMode.PKCS7;
        ICryptoTransform cTransform = tripleDES.CreateDecryptor();
        byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
        tripleDES.Clear();
        return UTF8Encoding.UTF8.GetString(resultArray);
    }


    protected void Save_Click(object sender, EventArgs e)
    {
        try
        {
            int Number = Auto_Increment("Select Count(reaction_id) from CETUpload_Reaction ", "Select Max(reaction_id) from CETUpload_Reaction ");
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string A1 = Encrypt(tb_Question_Name.Text, "AAECAwQFBgcICQoLDA0ODw==");
            string A2 = Encrypt(tb_Option_A.Text, "BBECAwQFBgcICQoLDA0ODw==");
            string A3 = Encrypt(tb_Option_B.Text, "CCECAwQFBgcICQoLDA0ODw==");
            string A4 = Encrypt(tb_Option_C.Text, "DDECAwQFBgcICQoLDA0ODw==");
            string A5 = Encrypt(tb_Option_D.Text, "EEECAwQFBgcICQoLDA0ODw==");
            string A6 = Encrypt(tb_Correct_Ans.Text, "FFECAwQFBgcICQoLDA0ODw==");
            string A7 = Encrypt(tb_Explaination.Text, "GGECAwQFBgcICQoLDA0ODw==");


            string strQuery = "Insert into CETUpload_Reaction (standard,subject,chapter_no,chapter_name,reaction_no,reaction_name,option_A,option_B,option_C,option_D,correct_ans,explanation,reaction_id) values(" + tb_Standard.Text + ", '" + tb_Subject.Text + "'," + tb_ChapterNo.Text + ", '" + dropdownlist_ChapterName.Text + "', " + tb_Que_No.Text + ", '" + A1 + "', '" + A2 + "', '" + A3 + "', '" + A4 + "', '" + A5 + "', '" + A6 + "', '" + A7 + "'," + Number + ")";

            SqlCommand cmd = new SqlCommand(strQuery);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();


            Response.Write("<script LANGUAGE='JavaSCript' > alert('Record Save Successfully')</script>");
            GetData();
            Clear_Control();
        }
        catch (Exception ex)
        {

        }


    }

    private void Clear_Control()
    {

        tb_ChapterNo.Text = "";
        //dropdownlist_ChapterName.Text = "";
        tb_Que_No.Text = "";
        tb_Question_Name.Text = "";
        tb_Option_A.Text = "";
        tb_Option_B.Text = "";
        tb_Option_C.Text = "";
        tb_Option_D.Text = "";
        tb_Correct_Ans.Text = "";
        tb_Explaination.Text = "";
        dropdownlist_ChapterName.SelectedIndex = -1;
    }

    protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    {
      //  grdView.PageIndex = e.NewPageIndex;
        this.GetData();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
