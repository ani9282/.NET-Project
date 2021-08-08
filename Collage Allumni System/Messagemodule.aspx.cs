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

public partial class Messagemodule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from Alumniregistration",con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        int length = dt.Rows.Count;
        for (int i = 0; i < length; i++)
        {

            String mobile = dt.Rows[i][2].ToString();
            string Username = "rahulpawar";
            string pass = "Rahul@123";
            string APIKey = "ROYALS";
            WebClient client = new WebClient();
            String Message = TextBox2.Text;
            string baseurl = "http://www.smssigma.com/API/WebSMS/Http/v1.0a/index.php?username=" + Username + "&password=" + pass + "&sender=" + APIKey + "&to=" + mobile + "&message='" + Message + "'&reqid=1&format={json|text}&route_id=7&msgtype=unicode";
            Stream data = client.OpenRead(baseurl);

            StreamReader reader = new StreamReader(data);
            string ResponseID = reader.ReadToEnd();
            data.Close();
            reader.Close();

        }
    }
}