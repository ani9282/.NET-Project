using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class SubjectWiseReport : System.Web.UI.Page
{
  //  private object FeedbackRdlc;

    protected void Page_Load(object sender, EventArgs e)
    { 
    TextBox2.Text = Session["Branch"].ToString();
    TextBox1.Text = Session["name"].ToString();
        }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {


        //string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        //SqlConnection con = new SqlConnection(connectionString);
        //SqlDataAdapter dd = new SqlDataAdapter("select * from TeacherAssgSub where TeacherName= '" + TextBox1.Text + "' AND Branch='"+TextBox2.Text+"' AND class='"+DropDownList1.Text+"' ", con);
        //DataTable tt = new DataTable();
        //dd.Fill(tt);
        //DropDownList2.DataSource = tt;
        //DropDownList2.DataTextField = "subjectName";
        //DropDownList2.DataValueField = "Branch";
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlDataAdapter dd = new SqlDataAdapter("select * from TeacherAssgSub where TeacherName= '" + TextBox1.Text + "' AND Branch='" + TextBox2.Text + "' AND class='" + DropDownList1.Text + "' ", con);
        DataTable tt = new DataTable();
        dd.Fill(tt);
        DropDownList2.DataSource = tt;
        DropDownList2.DataTextField = "subjectName";
        //  DropDownList2.DataValueField = "Branch";
        DropDownList2.DataBind();


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        Session["Branch"] = TextBox2.Text;

        Session["teacher"] = TextBox1.Text;

        Session["class"] = DropDownList1.Text;

        Session["subject"] = DropDownList2.Text;


        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        
       SqlDataAdapter dd = new SqlDataAdapter("select * from Feedback where teacher='" + TextBox1.Text + "' AND branch='" + TextBox2.Text + "' AND class='" + DropDownList1.Text + "' AND subject='" + DropDownList2.Text + "'", con);
        DataTable tt = new DataTable();
        dd.Fill(tt);
      
        int length = tt.Rows.Count;
        con.Open();

        SqlCommand dd2 = new SqlCommand("select SUM(PD) from Feedback where teacher='"+TextBox1.Text+ "'  AND branch='" + TextBox2.Text + "' AND class='" + DropDownList1.Text + "' AND subject='" + DropDownList2.Text + "'", con);
        dd2.Connection = con;

        decimal pdcount = Convert.ToDecimal(dd2.ExecuteScalar().ToString());

    
        SqlCommand dd3 = new SqlCommand("select SUM(DK) from Feedback where teacher='"+TextBox1.Text+ "'  AND branch='" + TextBox2.Text + "' AND class='" + DropDownList1.Text + "' AND subject='" + DropDownList2.Text + "'", con);
        dd3.Connection = con;
           
        decimal Dkcount =Convert.ToDecimal(dd3.ExecuteScalar().ToString());

        SqlCommand dd4 = new SqlCommand("select SUM(psskill) from Feedback where teacher='" + TextBox1.Text + "'  AND branch='" + TextBox2.Text + "' AND class='" + DropDownList1.Text + "' AND subject='" + DropDownList2.Text + "'", con);
        dd4.Connection = con;

        decimal psskillcount = Convert.ToDecimal(dd4.ExecuteScalar().ToString());

        SqlCommand dd5 = new SqlCommand("select SUM(AD) from Feedback where teacher='" + TextBox1.Text + "'  AND branch='" + TextBox2.Text + "' AND class='" + DropDownList1.Text + "' AND subject='" + DropDownList2.Text + "'", con);
        dd5.Connection = con;

        decimal ADcount = Convert.ToDecimal(dd5.ExecuteScalar().ToString());



        SqlCommand dd6 = new SqlCommand("select SUM(ES) from Feedback where teacher='" + TextBox1.Text + "'  AND branch='" + TextBox2.Text + "' AND class='" + DropDownList1.Text + "' AND subject='" + DropDownList2.Text + "'", con);
        dd6.Connection = con;
        decimal EScount = Convert.ToDecimal(dd6.ExecuteScalar().ToString());

        string connstr1 = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection conn1 = new SqlConnection(connstr1);
        //conn1.Open();
        //conn1.Close();
        
        conn1.Open();
        SqlCommand cmdd = new SqlCommand("delete from FinalFeedback where branch= '" + TextBox2.Text + "' AND class='" + DropDownList1.Text + "' AND teacher='" + TextBox1.Text + "'AND subject='" + DropDownList2.Text + "' ");
        cmdd.Connection = conn1;
        cmdd.ExecuteNonQuery();

        conn1.Close();


        for (int i = 0; i < length; i++)
        {
            decimal add = 0;
            decimal PD =Convert.ToDecimal(tt.Rows[i][4].ToString());
            decimal DK = Convert.ToDecimal(tt.Rows[i][5].ToString());
            decimal psskill = Convert.ToDecimal(tt.Rows[i][6].ToString());
            decimal AD = Convert.ToDecimal(tt.Rows[i][7].ToString());
            decimal ES = Convert.ToDecimal(tt.Rows[i][8].ToString());

            add = PD + DK + psskill + AD + ES;

            string connstr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con1 = new SqlConnection(connstr);

            con1.Open();
            SqlCommand cmd = new SqlCommand("insert into FinalFeedback(branch,class,teacher,subject,PD,DK,psskill,AD,ES,pdcount,Dkcount,psskillcount,ADcount,EScount,Total)values('" + TextBox2.Text + "','" + DropDownList1.Text + "','" + TextBox1.Text + "','" + DropDownList2.Text + "','" + PD + "','" + DK + "','" + psskill + "','" + AD + "','" + ES + "','"+ pdcount + "','" + Dkcount + "','"+ psskillcount + "','"+ADcount+"','"+EScount+"','"+add+"')", con1);
            cmd.Connection = con1;
            cmd.ExecuteNonQuery();
     
            con1.Close();


        }
       Response.Redirect("FinalRdlc.aspx");
        
    }


    protected void Button2_Click1(object sender, EventArgs e)
    {

        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlDataAdapter dd = new SqlDataAdapter("select * from TeacherAssgSub where TeacherName= '" + TextBox1.Text + "' AND Branch='" + TextBox2.Text + "' AND class='" + DropDownList1.Text + "' ", con);
        DataTable tt = new DataTable();
        dd.Fill(tt);
        DropDownList2.DataSource = tt;
        DropDownList2.DataTextField = "subjectName";
      //  DropDownList2.DataValueField = "Branch";
        DropDownList2.DataBind();
    }
}