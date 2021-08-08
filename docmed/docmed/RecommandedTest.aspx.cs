using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RecommandedTest : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["pName"] == null)
        {
            Response.Redirect("~/index.html");
        }
    }

    public DataSet Bind()
    {
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        MySqlCommand cmd = new MySqlCommand("select * from PrescriptionDetailsDoctor where RfID='" + TextBox1.Text + "'", con);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
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


    protected void Button2_Click(object sender, EventArgs e)
    {
        DataSet ds = Bind();

        if (!object.Equals(ds, null))
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.Visible = true;
               // textinput.Text = " ";
               // Label2.Text = " ";
            }


            else
            {
                GridView1.Visible = false;
               // Label2.Visible = true;
                //Label2.Text = "not available in the record";

            }
        }
    }


 }