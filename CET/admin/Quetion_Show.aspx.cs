using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Quetion_Show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int i = 0;
            tb_T_Marks.Text = Convert.ToString(Session["Total_Marks"]);

            tb_Time.Text = Convert.ToString(Session["Total_Time"]);
            DataTable dt = new DataTable();

            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Chapter_No From CET_Tempory_tbl", con);

            var Obj = cmd.ExecuteReader();
            while (Obj.Read())
            {
                /*
                int Number = Convert.ToInt32(Obj["Chapter_No"].ToString());

                SqlDataAdapter sda = new SqlDataAdapter("Select Q_ID,Question_Name From CET_tbl_Question Where Q_ID = " + Number + "", con);
                sda.Fill(dt);
                sda.Dispose();*/
                i++;

            }
            //i -= 1;
            Obj.Close();
            SqlCommand cmd1 = new SqlCommand("Select Chapter_No From Temperoy_CET_Chapter_Number", con);

            
            while (i > 0)
            {
                var Obj1 = cmd1.ExecuteReader();
                while (Obj1.Read())
                {
                    int j = 0;
                    int Number = Convert.ToInt32(Obj1["Chapter_No"].ToString());

                    Obj1.Close();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Q_ID,Question_Name From CET_tbl_Question Where Q_ID = " + Number + "", con);
                    sda.Fill(dt);
                    sda.Dispose();

                    cmd1.Dispose();
                    break;
                    
                }
                i--;
            }

            GDV_Chapter_Show.DataSource = dt;
            GDV_Chapter_Show.DataBind();

            SqlCommand cmd2 = new SqlCommand("Delete From Temperoy_CET_Chapter_Number",con);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();

            con.Close();

        }
        
    }
}