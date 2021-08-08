using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_EditChapter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getData();

            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);



            con.Open();

            string com = "Select * from CET_tblSubject";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();


            adpt.Fill(dt);



            DropDownList2.DataSource = dt;

            DropDownList2.DataTextField = "Subject_Name";
            DropDownList2.DataValueField = "Subject_Name";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("Select Subject", "Select Subject"));
            DropDownList2.SelectedIndex = 0;
        }
    }
    public void getData()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);




        con.Open();

      
        SqlDataAdapter sda = new SqlDataAdapter("Select Standard,Subject,Chapter_ID,ChapterName from CET_Chapter", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        grdView.DataSource = dt;
         grdView.DataBind();
    }
    protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "lnkbtnDelete")
        {

            string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });

            string Standard = commandArgs[0];
            string Subject = commandArgs[1];
            string CNo = commandArgs[2];

            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            //var name = this.Request.Form["Subject"];

            SqlCommand cmd = new SqlCommand("Delete from CET_Chapter where Standard = " + Convert.ToInt32(Standard) + " And Subject = '" + Subject + "' And Chapter_ID = " + Convert.ToInt32(CNo) + "", con);

            cmd.ExecuteNonQuery();

            con.Close();
            getData();
            //var id = Int32.Parse(e.CommandArgument);
            // grdView.DeleteRow(id);      
        }

        if (e.CommandName == "lnkbtnEdit")
        {

            // Response.Redirect("Update_ChapterMaster.aspx? Standard=" + Standard);
            string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
            string Standard = commandArgs[0];
            string Subject = commandArgs[1];
            string CNo = commandArgs[2];
            string CName = commandArgs[3];
            Response.Redirect("Update_ChapterMaster.aspx?Standard=" + Standard + "&Subject=" + Subject + "&CNo=" + CNo + "&CName=" + CName);



        }
    }
}