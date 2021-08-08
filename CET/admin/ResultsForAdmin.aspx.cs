using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ResultsForAdmin : System.Web.UI.Page
{
    public static int ExamID = 0;

    public static int id;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            id = int.Parse(Request.QueryString["id"]);

            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            DataTable dt1 = new DataTable();
            string Query1 = "select ExamID,RollNo,Name,TotalQuestions,SolvedQuestions,TotalMarks,ObtainedMarks from CET_StudentResult where ExamID = " + id + " order by RollNo";


            SqlDataAdapter sda1 = new SqlDataAdapter(Query1, con);
            sda1.Fill(dt1);
            ExamID = id;
            abc.DataSource = dt1;
            abc.DataBind();
        }
        
    }

    protected void abc_SelectedIndexChanged(object sender, EventArgs e)
    {
        //int index = abc.SelectedRow.RowIndex;
        // int ID = Convert.ToInt32(abc.SelectedRow.Cells[0].Text);
        // string message = "Row Index: " + index + "\\ContactID: ";
        //  Response.Write("<script language='javascript'>window.alert('Record Updated Successfully ');</script>");
        foreach (GridViewRow row in abc.Rows)
        {
            if (row.RowIndex == abc.SelectedIndex)
            {
                row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                row.ToolTip = string.Empty;
            }
            else
            {
                row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                row.ToolTip = "Click to select this row.";
            }
        }
    }

    protected void abc_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(abc, "Select$" + e.Row.RowIndex);
            e.Row.ToolTip = "Click to select this row.";
        }
    }
}