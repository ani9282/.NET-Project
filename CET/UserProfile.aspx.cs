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

public partial class UserProfile : System.Web.UI.Page
{
    protected string Name { get; set; }
    protected string LName { get; set; }

    protected string email1 { get; set; }

    protected string mobile { get; set; }
    protected string msg { get; set; }
    protected int id;
    protected string home1 { get; set; }

    protected string address1 { get; set; }

    protected string zipcode { get; set; }

    protected string city1 { get; set; }


    protected string region { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        String email = Session["Email"].ToString();
        String Password = Session["Password"].ToString();

        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        SqlDataAdapter da = new SqlDataAdapter("Select * from Man_Account where email='" + email + "' AND password='" + Password + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Name = dt.Rows[0][1].ToString();
            LName = dt.Rows[0][2].ToString();
            email1 = email;
            id = Convert.ToInt32(dt.Rows[0][0].ToString());

        }

        SqlDataAdapter da1 = new SqlDataAdapter("Select * from tblProfile where email='" + email + "'", con);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            mobile = dt1.Rows[0][3].ToString();
            msg= dt1.Rows[0][5].ToString();
            exampleFormControlTextarea1.Value = msg;
            home1 = dt1.Rows[0][6].ToString();
            address1 = dt1.Rows[0][7].ToString();
            zipcode = dt1.Rows[0][8].ToString();
            city1 = dt1.Rows[0][9].ToString();
            region = dt1.Rows[0][11].ToString();
        }




    }









    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        String name = Name;
        String lname = LName;
        String email = email1;
        String mobile = Request.Form["mobile"];

        
        String msg=exampleFormControlTextarea1.Value;
        String home = Request.Form["home"];
        String address = Request.Form["address"];
        String zipcode = Request.Form["zipcode"];
        String country = Request.Form["country"];
        String city = Request.Form["city"];
        String state = Request.Form["state"];
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("Select * from tblProfile where ID='" + id + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string Username = "rahulpawar";
            string pass = "Rahul@123";
            string APIKey = "ROYALS";
            WebClient client = new WebClient();
            String Message = "You have Successfully Updated Settings with Maangalya Shopping Mall";
            string baseurl = "http://www.smssigma.com/API/WebSMS/Http/v1.0a/index.php?username=" + Username + "&password=" + pass + "&sender=" + APIKey + "&to=" + mobile + "&message='" + Message + "'&reqid=1&format={json|text}&route_id=7&msgtype=unicode";
            Stream data = client.OpenRead(baseurl);

            StreamReader reader = new StreamReader(data);
            string ResponseID = reader.ReadToEnd();
            data.Close();
            reader.Close();
            cmd.CommandText = "Update tblProfile set FirstName='"+name+"',LastName='"+lname+"',Mobile='"+mobile+"',Email='"+email+"',Message='"+msg+"',company='"+home+"',Address='"+address+"',zipcode='"+zipcode+"',country='"+country+"',city='"+city+"',regionstate='"+state+"' where ID='"+id+"'";
            cmd.ExecuteNonQuery();

            ModalPopupExtender1.Show();

        }

        else
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into tblProfile values('" + id + "','" + name + "','" + lname + "','" + mobile + "','" + email + "','" + msg + "','" + home + "','" + address + "','" + zipcode + "','" + country + "','" + country + "','" + state + "')";
            cmd.ExecuteNonQuery();
            string Username = "rahulpawar";
            string pass = "Rahul@123";
            string APIKey = "ROYALS";
            WebClient client = new WebClient();
            String Message = "You have Successfully Registered with Maangalya Shopping Mall";
            string baseurl = "http://www.smssigma.com/API/WebSMS/Http/v1.0a/index.php?username=" + Username + "&password=" + pass + "&sender=" + APIKey + "&to=" + mobile + "&message='" + Message + "'&reqid=1&format={json|text}&route_id=7&msgtype=unicode";
            Stream data = client.OpenRead(baseurl);

            StreamReader reader = new StreamReader(data);
            string ResponseID = reader.ReadToEnd();
            data.Close();
            reader.Close();
            ModalPopupExtender1.Show();
        }

    }
}