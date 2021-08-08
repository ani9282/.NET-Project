using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Update_Data : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            string Query = "Select * from CET_tblSubject";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Connection = con;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CHKB_Subject.DataTextField = "Subject_Name";
            CHKB_Subject.DataValueField = "Subject_ID";
            CHKB_Subject.DataSource = dt;
            CHKB_Subject.DataBind();
            con.Close();
        }
    }

    protected void CHKB_Subject_SelectedIndexChanged(object sender, EventArgs e)
    {
        for (int i = 0; i < CHKB_Subject.Items.Count; i++)
        {
            if (CHKB_Subject.Items[0].Selected)
            {
                lbl_Physics.Visible = true;
                lbl_Physics.Text = CHKB_Subject.Items[0].Text;
                tb_Physics.Visible = true;
            }
            else
            {
                lbl_Physics.Visible = false;

                tb_Physics.Visible = false;
                tb_Physics.Text = "";

            }
            if ((CHKB_Subject.Items[1].Selected))
            {
                lbl_Chemistry.Visible = true;
                lbl_Chemistry.Text = CHKB_Subject.Items[1].Text;
                tb_Chemistry.Visible = true;
            }
            else
            {
                lbl_Chemistry.Visible = false;

                tb_Chemistry.Visible = false;
                tb_Chemistry.Text = "";

            }
            if (CHKB_Subject.Items[2].Selected)
            {
                lbl_Maths.Visible = true;
                lbl_Maths.Text = CHKB_Subject.Items[2].Text;
                tb_Maths.Visible = true;
            }
            else
            {
                lbl_Maths.Visible = false;

                tb_Maths.Visible = false;
                tb_Maths.Text = "";
            }

            if (CHKB_Subject.Items[3].Selected)
            {
                lbl_Biology.Visible = true;
                lbl_Biology.Text = CHKB_Subject.Items[3].Text;
                tb_Biology.Visible = true;
            }
            else
            {
                lbl_Biology.Visible = false;

                tb_Biology.Visible = false;
                tb_Biology.Text = "";
            }
        }

    }



    protected void btn_View_Click(object sender, EventArgs e)
    {

    }
}