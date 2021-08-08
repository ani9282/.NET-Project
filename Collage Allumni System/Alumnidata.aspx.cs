using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Alumnidata : System.Web.UI.Page
{

    string cons = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

        
    }


    public DataSet Bind()
    {

        SqlConnection con = new SqlConnection(cons);
        SqlCommand cmd = new SqlCommand("select * from Alumniregistration where alumniname like'" + textinput.Text + "%'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (!object.Equals(ds, null))
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                GridView1.ForeColor = System.Drawing.Color.Black;
            }

        }


        return ds;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSet ds = Bind();

        if (!object.Equals(ds, null))
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.Visible = true;
                textinput.Text = " ";
                Label2.Text = " ";
            }


            else
            {
                GridView1.Visible = false;
                Label2.Visible = true;
                Label2.Text = "not available in the record";

            }
        }
    }


}