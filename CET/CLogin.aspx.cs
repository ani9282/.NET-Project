using Instamojo.NET.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected async void Button1_Click(object sender, EventArgs e)
    {
        String email = Request.Form["email"];
        String password = Request.Form["password"];

        String Mycurrentsession = Session["SES"].ToString();

        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        decimal amount = 0;
        decimal amount1 = 0;
        SqlDataAdapter da2 = new SqlDataAdapter("Select * from tblCart where Sessionid='" + Mycurrentsession + "'", con);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);
        int length = dt2.Rows.Count;
        for(int i=0;i<length;i++)
      
        {

            amount  = Convert.ToDecimal( dt2.Rows[i][6].ToString());
            amount1 += amount;
        }


        string str = amount1.ToString();

        SqlDataAdapter da = new SqlDataAdapter("Select * from Man_Account where email='" + email + "' AND password='" + password + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            String name = dt.Rows[0][1].ToString();

            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tblProfile where email='" + email + "'", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {

                Session["User"] = email;

                String Phone = dt1.Rows[0][3].ToString();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                Instamojo.NET.Instamojo im = new Instamojo.NET.Instamojo("0f010be0709c18bd3ac0ec37e472aee1", "49c00796f7f2b9062d6a8e8b63395fc0");
                PaymentRequest pr = new PaymentRequest();
                pr.allow_repeated_payments = false;
                pr.amount = str;
                pr.buyer_name = name;
                pr.email = email;
                pr.phone = Phone;
                pr.send_email = true;
                pr.send_sms = true;
                pr.redirect_url = "http://localhost:55400//SUS.aspx?SID='" + Mycurrentsession+"'";
             
                pr.webhook = "https://naveen.me/webhook";
                pr.purpose = "Product Purchase";
                PaymentRequest npr = await im.CreatePaymentRequest(pr);
                String PaymentURL = npr.longurl;
                Response.Redirect(PaymentURL);
                String PaymentRequestId = npr.longurl;
            }

        }
        else
        {
            ModalPopupExtender1.Show();

        }
    }
}