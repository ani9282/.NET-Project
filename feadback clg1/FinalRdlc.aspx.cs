using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WebForms;

public partial class FinalRdlc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ReportViewer1.Reset();
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Report2.rdlc");
            String str = Session["teacher"].ToString();
            String st = Session["class"].ToString();
            String sr = Session["subject"].ToString();


            feedbackcollageDataSet dsCustomers = GetData("select * from FinalFeedback where teacher='" + str + "'AND class='" + st + "'AND subject='" + sr + "' ");
            ReportDataSource datasource = new ReportDataSource("DataSet1", dsCustomers.Tables[0]);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
        }

    }
    private feedbackcollageDataSet GetData(string query)
    {
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection ConString = new SqlConnection(conn);

        SqlCommand cmd = new SqlCommand(query);
        using (SqlConnection con = new SqlConnection(conn))
        {
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                cmd.Connection = con;

                sda.SelectCommand = cmd;
                using (feedbackcollageDataSet dsCustomers = new feedbackcollageDataSet())
                {
                    sda.Fill(dsCustomers, "FinalFeedback");
                    return dsCustomers;
                }
            }
        }
    }
}