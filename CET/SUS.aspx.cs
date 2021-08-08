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
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class SUS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["payment_status"] != null && Request.QueryString["payment_status"] != string.Empty)
        {
            String status = Request.QueryString["payment_status"];
            if (status == "Failed")
            {
                Label1.Text = "Your Payment Status Failed Please Retry Again";
            }
            else if (status=="Credit")
            {
                string Mycurrentsession = Request.QueryString["SID"];
               // String Mycurrentsession = Session["SES"].ToString();
                decimal amount = 0;
                decimal amount1 = 0;
                int productid = 0;
                int quantitiy = 0;
                decimal rate = 0;
                decimal finalprice = 0;
                String size = null;
                String email = Session["User"].ToString();
                String productname = null;
                Label1.Text = "Thank You Your Payment Successfull";

                string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("Select * from tblCart where Sessionid='" + Mycurrentsession + "'", con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                int length = dt2.Rows.Count;
                for (int i = 0; i < length; i++)

                {
                    productname = dt2.Rows[i][2].ToString();
                    productid = Convert.ToInt32(dt2.Rows[i][1].ToString());
                    amount = Convert.ToDecimal(dt2.Rows[i][6].ToString());
                    size = dt2.Rows[i][3].ToString();
                    quantitiy = Convert.ToInt32(dt2.Rows[i][4].ToString());
                    rate = Convert.ToDecimal(dt2.Rows[i][5].ToString());
                    finalprice = Convert.ToDecimal(dt2.Rows[i][6].ToString());
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Insert into tblFinal values('"+email+"','"+productid+"','"+productname+"','"+size+"','"+quantitiy+"','"+rate+"','"+finalprice+"') ";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                   
                 



                }

                SqlCommand cmd1 = new SqlCommand("Delete from tblCart where Sessionid='" + Mycurrentsession + "'");
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();


                SqlDataAdapter da3 = new SqlDataAdapter("Select * from tblProfile where Email='" + email + "'", con);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                if (dt3.Rows.Count > 0)
                {

                    String mobile = dt3.Rows[0][3].ToString();

                    string Username = "rahulpawar";
                    string pass = "Rahul@123";
                    string APIKey = "ROYALS";
                    WebClient client = new WebClient();
                    String Message = "Your Order has been successfully Placed on Maangalya Shopping Maal";
                    string baseurl = "http://www.smssigma.com/API/WebSMS/Http/v1.0a/index.php?username=" + Username + "&password=" + pass + "&sender=" + APIKey + "&to=" + mobile + "&message='" + Message + "'&reqid=1&format={json|text}&route_id=7&msgtype=unicode";
                    Stream data = client.OpenRead(baseurl);

                    StreamReader reader = new StreamReader(data);
                    string ResponseID = reader.ReadToEnd();
                    data.Close();
                    reader.Close();
                }






            }
        }
        HtmlMeta meta = new HtmlMeta();
        meta.HttpEquiv = "Refresh";
        meta.Content = "15;url=Default.aspx";
        this.Page.Controls.Add(meta);
    }
}