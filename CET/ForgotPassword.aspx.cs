using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try { 
        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("info@medivacation.in");
        String to = "rahulpawar9766@gmail.com";
        msg.To.Add(to);
        msg.Subject = "";
            msg.Body = "s";


        msg.IsBodyHtml = true;


        SmtpClient sc = new SmtpClient();

        sc.Host = "relay-hosting.secureserver.net";
        // sc.DeliveryMethod = 
        // sc.UseDefaultCredentials = true;
        sc.Send(msg);
        Response.Write("<script LANGUAGE='JavaScript' >alert('Send Message Successfully')</script>");
    }
        catch (Exception ex)
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Send Message Successfully')</script>" + ex);

        }
    }
}