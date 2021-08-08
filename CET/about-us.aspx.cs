using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class about_us : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlDataAdapter da1 = new SqlDataAdapter("Select * from tblFiles1", con);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);
        int length1 = dt1.Rows.Count;
        for (int i = 0; i <= length1; i++)
        {
            if (i == 0)
            {
                Label6.Text = dt1.Rows[i][4].ToString();


            }

            if (i == 1)
            {
                Label7.Text = dt1.Rows[i][4].ToString();


            }

        }
    }
}