using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_MCQ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = 4;

        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlDataAdapter sda = new SqlDataAdapter("Select * from CETUpload_Reaction where reaction_id="+ 6+"", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        string A1 = (string)dt.Rows[0][5];
        string A2 = (string)dt.Rows[0][6];
        string A3 = (string)dt.Rows[0][7];
        string A4 = (string)dt.Rows[0][8];
        string A5 = (string)dt.Rows[0][9];


        string B1 = Decrypt(A1, "AAECAwQFBgcICQoLDA0ODw==");
        string B2 = Decrypt(A2, "BBECAwQFBgcICQoLDA0ODw==");
        string B3 = Decrypt(A3, "CCECAwQFBgcICQoLDA0ODw==");
        string B4 = Decrypt(A4, "DDECAwQFBgcICQoLDA0ODw==");
        string B5 = Decrypt(A5, "EEECAwQFBgcICQoLDA0ODw==");


        tb_Subject.Text = "1";
        TextBox1.Text = B1;
        TextBox2.Text = B2;
        TextBox3.Text = B3;
        TextBox4.Text = B4;
        TextBox5.Text = B5;


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
}