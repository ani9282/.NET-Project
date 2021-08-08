using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;

public partial class Eventmaster : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=collage Alumni;Integrated Security=True");
    SqlCommand com;
    private int i;

    protected void Page_Load(object sender, EventArgs e)
    {
        // DropDownList1.Text=Session[" Eventname"].ToString();

        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlDataAdapter sa = new SqlDataAdapter("Select Date from Eventmaster1 Where Eventname='" + DropDownList1.Text + "'", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {
             //TextBox1.Text = dt.Rows[0][2].ToString();
             TextBox1.Text = DateTime.Now.ToString("MM/dd/yyyy");

        }

    }


    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (rbtn1.Checked == true)
        {
            //WebCSDBConnectionString2
            string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            //SqlConnection con = new SqlConnection("ConString");
            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            {
                com.CommandText = "insert into Eventmaster values(@Eventname, @date,@Event)";

                com.Parameters.Clear();

                //com.Parameters.AddWithValue("@Eventid", txtid.Text);

                com.Parameters.AddWithValue("@Eventname", DropDownList1.Text);

                com.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));

                com.Parameters.AddWithValue("@Event", rbtn1.Text);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                com.ExecuteNonQuery();

                con.Close();
                // lblmsg.Text = "Data entered successfully!!!";
                // clear();
            }
        }

        else
        {
            string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            //SqlConnection con = new SqlConnection("ConString");

            com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Eventmaster values( @Eventname, @date,@Event)";

            com.Parameters.Clear();

            //com.Parameters.AddWithValue("@Eventid", txtid.Text);

            com.Parameters.AddWithValue("@Eventname", DropDownList1.Text);

              com.Parameters.AddWithValue("@Date", DateTime.Now.ToString("MM/dd/yyyy"));

            com.Parameters.AddWithValue("@Event", rbtn2.Text);
            if (con.State == ConnectionState.Closed)

                con.Open();


            //else

            //{
            //}


            com.ExecuteNonQuery();


            con.Close();

            Response.Redirect("Dashbord1.aspx");

            // lblmsg.Text = "Data entered successfully!!!";

            clear();

        }

    }

    void clear()
    {
        // txtid.Text = "";

        // txtname.Text = "";



        rbtn1.Checked = false;

        rbtn2.Checked = false;

    }






    //    //string name = txtname.Text.Trim();


    //    string Event = string.Empty;
    //    if (rbtn1.Checked)
    //    {
    //        Event = "instreted";
    //    }
    //    else if (rbtn2.Checked)
    //    {
    //        Event = "Not instreted";
    //    }
    //    string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
    //    SqlConnection con = new SqlConnection(conn);
    //    {
    //        SqlCommand cmd = new SqlCommand("INSERT INTO Eventmaster(Eventname,date, Event) VALUES(@Eventname,@date, @Event)", con);
    //        {
    //            cmd.Connection = con;
    //            cmd.Parameters.AddWithValue("@Eventid", txtid.Text);
    //            cmd.Parameters.AddWithValue("@Eventname", DropDownList1.Text);
    //            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));
    //            cmd.Parameters.AddWithValue("@Event", Event);

    //            con.Open();
    //            cmd.ExecuteNonQuery();
    //            GridView1.DataBind();






    //            clear();
    //            con.Close();

    //            Response.Redirect("Dashboard.aspx");
    //        }
    //    }
    //}


    //private void clear()
    //{
    //    txtid.Text = " ";
    //    DropDownList1.Text = " ";


    //}





    protected void Button2_Click(object sender, EventArgs e)
    {
       //// DateTime.MaxValue = DateTime.Today;

     // string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
       // SqlConnection con = new SqlConnection(conn);
       // con.Open();
       // SqlCommand cmd = new SqlCommand();
       // cmd.CommandText = "Select MAX(Eventid) from Eventmaster";
       // cmd.Connection = con;
       // int i = 0;
       // try
       // {
       //     i = Convert.ToInt32(cmd.ExecuteScalar());
       //     i++;
       //     txtid.Text = i.ToString();
       // }
       // catch (Exception ex)
       // {

       //     txtid.Text = "1";

       //     cmd.ExecuteNonQuery();


       // }
    }

    protected void Button4_Click(object sender, EventArgs e)
{
        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);
        con.Open();
        //SqlCommand cmd = new SqlCommand();
        SqlCommand cmd = new SqlCommand("Delete from Eventmaster where Eventname ='" + DropDownList1.Text + "'", con);
        // cmd.CommandText = "Delete from staffregistration where teacherid ='" + txtid.Text + "'";
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();
        //cleardata();
       // GridView1.DataBind();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Delete Successful')</script>");
    }
    private void cleardata()
    {
        //txtid.Text = " ";
        //txtname.Text = " ";



    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        //SqlConnection con = new SqlConnection(conn);
        //con.Open();
        //SqlCommand cmd = new SqlCommand();
        //cmd.CommandText = "Update Eventmaster set Eventname='" + txtname.Text + "',date='" + DateTime.Now.ToString("MM/dd/yyyy") + "' where Eventid='" + txtid.Text + "'";
        //cmd.Connection = con;
        //cmd.ExecuteNonQuery();
        //GridView1.DataBind();


        //clearall();
        //Response.Write("<script LANGUAGE='JavaScript' >alert('Update Successful')</script>");


    }
    private void clearall()
    {
        //txtid.Text = " ";
        //txtname.Text = " ";
       

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

        
        
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void date_TextChanged(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged1(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged2(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        //txtid.Text = GridView1.SelectedRow.Cells[1].Text;
        //DropDownList1.Text = GridView1.SelectedRow.Cells[2].Text;

    }
}

