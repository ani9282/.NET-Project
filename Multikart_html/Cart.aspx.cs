using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getData();
        }
    }

    public void getData()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);

        try
        {

            if (Session["SES"] == null)
            {
                Label1.Text =Convert.ToDecimal("0.00").ToString();

            }
            else
            {
                String Mycurrentsession = Session["SES"].ToString();
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select ProductId,Productname,Quantiy,Rate,Price,ImageURL from tblCart where Sessionid='" + Mycurrentsession + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grdView.DataSource = dt;
                grdView.DataBind();


                SqlCommand cmd = new SqlCommand("Select sum(price) from tblCart where Sessionid='" + Mycurrentsession + "'", con);
                cmd.Connection = con;
                decimal a = Convert.ToDecimal(cmd.ExecuteScalar().ToString());
                Label1.Text = a.ToString();
            }
        }
        catch (Exception ex)
        {
            Label1.Text = Convert.ToDecimal("0.00").ToString();

        }
    }

    protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        /* This condition work when click on edit button */
      

        /* This condition work when click on delete button */
        if (e.CommandName == "lnkbtnDelete")
        {
            int id = int.Parse(e.CommandArgument.ToString());
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            





            SqlCommand cmd = new SqlCommand("delete from tblCart where ProductId='" + id + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();

            getData();

            


            con.Close();
             /* Reload gridview */
        }
    }

}