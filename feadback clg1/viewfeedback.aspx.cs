using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class viewfeedback : System.Web.UI.Page
{
    private Style auto;

    public Style Style2 { get; private set; }
    public object FeedbackRdlc { get; private set; }

    int i = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        Label1.Text = Session["name"].ToString();
        txtbranch.Text = Session["branch"].ToString();
          txtclass.Text = Session["class"].ToString();
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            int id = 1;
            SqlDataAdapter da = new SqlDataAdapter("select * from SemesterMaster where SemesterId ='" + id + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtsem.Text = dt.Rows[0][1].ToString();
            }
            if (i == 0)
            {

                
                i++;
            }
            
        
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        //SqlConnection con = new SqlConnection(connectionString);
        //con.Open();
        //SqlCommand cmd = new SqlCommand("insert into feedback (Branch,class,subject,semister,TeacherName,Punctuality & Discipline,Domain Knowledge, Presentation skill & Interaction With Students,Ability To Resolve Difficulties,Effective Use Of Teaching Aids)values('"+txtbranch.Text+ "','" + txtclass.Text + "','" + txtsub.Text + "','" + txtsem.Text + "','" + txttname.Text + "','" + txtpun.Text + "','" + txtdomain.Text + "','" + txtpre.Text + "','" + txtability + "','" + txteff.Text + "')",con);
        //cmd.Connection = con;
        //cmd.ExecuteNonQuery();
        //con.Close();

        ////Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");


        ////con.Open();
        

        string conn = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(conn);

        String str = DropDownList1.SelectedItem.ToString();
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into feedback (Branch,class,subject,semister,teacher,PD,DK,psskill,AD,ES,Studentname)values('" + txtbranch.Text + "','" + txtclass.Text + "','" + str + "','" + txtsem.Text + "','" + txttname.Text + "','" + txtpun.Text + "','" + txtdomain.Text + "','" + txtpre.Text + "','" + txtability.Text + "','" + txteff.Text + "','"+Label1.Text+"')", con);
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful')</script>");
        clear();
      
    }
    private void clear()
    {
      //txtclass .Text = " ";
        //txtbranch.Text = " ";
        txtdomain.Text = " ";
        txteff.Text = " ";
        txtpre.Text = " ";
        txtpun.Text = " ";
        //txtsem.Text = " ";
        txttname.Text = " ";
        txtability.Text = " ";
        

    }

    protected void txtsub_SelectedIndexChanged(object sender, EventArgs e)

    {
        
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        String str = DropDownList1.Text;
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlDataAdapter dd = new SqlDataAdapter("select * from TeacherAssgSub where subjectName= '" + str+ "' ", con);
        DataTable tt = new DataTable();
        dd.Fill(tt);
        if (tt.Rows.Count > 0)
        {
            txttname.Text = tt.Rows[0][1].ToString();

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter dd = new SqlDataAdapter("select * from subjectMaster1 where Branch='" + txtbranch.Text + "' AND class='" + txtclass.Text + "' AND SemesterName='" + txtsem.Text + "' ", con);
            DataTable tt = new DataTable();
            dd.Fill(tt);
            DropDownList1.DataSource = tt;

        DropDownList1.DataTextField = "Subjectname";
        DropDownList1.DataValueField = "Subjectcode";
        DropDownList1.DataBind();
        
    }

    protected void Button1_Click2(object sender, EventArgs e)
    {
        String str = DropDownList1.SelectedItem.ToString();
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlDataAdapter dd = new SqlDataAdapter("select * from TeacherAssgSub where subjectName= '" + str + "' ", con);
        DataTable tt = new DataTable();
        dd.Fill(tt);
        if (tt.Rows.Count > 0)
        {
            txttname.Text = tt.Rows[0][1].ToString();

        }

    }
}

    
