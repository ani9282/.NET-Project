using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

public partial class PrescriptionDDaspx : System.Web.UI.Page
{
    static string DoctorNO;
    DataTable dt = new DataTable();
    public String Address = String.Empty;
    [WebMethod]
    public static string[] GetCustomers(string prefix)
    {
        List<string> customers = new List<string>();
        using (MySqlConnection conn = new MySqlConnection())
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "select medicineName from MedicineInfo where MedicineName like '" + prefix + "' '%'";

                cmd.Connection = conn;
                conn.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(string.Format("{0}", sdr["medicineName"]));
                    }
                }
                conn.Close();
            }
        }
        return customers.ToArray();
    }

    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["dName"] == null)
        {
            Response.Redirect("~/index.html");
        }

        else
        {
            if (Page.IsPostBack)
            {
                if (ViewState["records"] == null)
                {
                    dt.Columns.Add("ID");        
                    dt.Columns.Add("Description");
                    dt.Columns.Add("Tablet Name");
                    dt.Columns.Add("Quantity");
                    dt.Columns.Add("Morning");
                    dt.Columns.Add("Afternoon");
                    dt.Columns.Add("Night");
                    ViewState["records"] = dt;
                    //  dt.Columns.Add("ID");
                }
            }

        }
        TextBox14.Text="N.A";
           TextBox16.Text= "N.A";
         TextBox17.Text= "N.A";
        TextBox25.Text= "N.A";


        string constr1 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr1);
        con1.Open();
        MySqlDataAdapter sa1 = new MySqlDataAdapter("select * from DoctorReg where Name='" + Session["dName"] + "'", con1);
        DataTable dt1 = new DataTable();
        sa1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            DoctorNO = dt1.Rows[0][3].ToString();
           
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        string id = TextBox1.Text;
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlDataAdapter sa = new MySqlDataAdapter("select * from Petiant where rfidNo='" + id + "'", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            TextBox2.Text = dt.Rows[0][2].ToString();
            TextBox3.Text = dt.Rows[0][3].ToString();
            TextBox4.Text = dt.Rows[0][4].ToString();
            TextBox5.Text = dt.Rows[0][5].ToString();
            TextBox6.Text = dt.Rows[0][6].ToString();
            TextBox7.Text = dt.Rows[0][7].ToString();
            TextBox8.Text = dt.Rows[0][8].ToString();
            TextBox9.Text = dt.Rows[0][9].ToString();
            TextBox10.Text = dt.Rows[0][10].ToString();
      
            //  decs = dt.Rows[0][2].ToString();

            //   add = dt.Rows[0][2].ToString();



        }
    }

    

    protected void Button2_Click(object sender, EventArgs e)
    {
        string id = TextBox1.Text;
        string decs = TextBox11.Text;
        string tname = TextBox12.Text;
        dt = (DataTable)ViewState["records"];
        dt.Rows.Add(id, decs,tname, TextBox13.Text, DropDownList1.Text, DropDownList2.Text, DropDownList3.Text);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {


        string id = TextBox1.Text;
        String dName = Session["dName"].ToString();
        string decs = TextBox11.Text;
        string name = TextBox2.Text;
        DateTime.Now.ToString();
        string tanme = TextBox12.Text;
        string substance = TextBox14.Text;
        string reaction = TextBox16.Text;
        string discription= TextBox17.Text;
        string alert= TextBox25.Text;
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();
        try
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into PrescriptionDetailsDoctor (patientname,Description,date,DoctorName,DoctorNO,RfID,substance, reaction,discription,recommanded_test)values ('" + name + "','" + decs + "','" + DateTime.Now.ToString() + "','" + dName + "','" + DoctorNO + "','" + id + "','"+substance+"','"+reaction+"','"+discription+"','"+alert+"')";
            cmd.Parameters.AddWithValue("patientname", name);
            cmd.Parameters.AddWithValue("Description", decs);
            cmd.Parameters.AddWithValue("date", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("DoctorName", dName);
            cmd.Parameters.AddWithValue("DoctorNO", DoctorNO);
            cmd.Parameters.AddWithValue("RfID", id);
            cmd.Parameters.AddWithValue("substance",substance);
            cmd.Parameters.AddWithValue("reaction", reaction);
            cmd.Parameters.AddWithValue("discription",discription);
            cmd.Parameters.AddWithValue("recommanded_test", alert);
            cmd.ExecuteNonQuery();
        }

        catch
        {
            throw;
        }




        foreach (GridViewRow row in GridView1.Rows)

            {
                
                 DataRow dr = dt.NewRow();
                string Description = row.Cells[1].Text;
                string tname = row.Cells[2].Text;
                string qty = row.Cells[3].Text;
                string morning = row.Cells[4].Text;
                string aftermoon = row.Cells[5].Text;
                string night = row.Cells[6].Text;
              
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into patienttabletinfo (Rfid,Description,Tablet_name,Quantity,Morning,Afternoon,Night)values ('" + id+"','" + decs + "','" + tname + "','"+morning+"','"+aftermoon+"','"+night+"','"+qty+"')";
                cmd.Parameters.AddWithValue("RfID", id);
                cmd.Parameters.AddWithValue("Description", Description);       
                cmd.Parameters.AddWithValue("Tablet_name",tname);
                cmd.Parameters.AddWithValue("Morning", morning);
                cmd.Parameters.AddWithValue("Afternoon", aftermoon);
                cmd.Parameters.AddWithValue("Night", night);
                cmd.Parameters.AddWithValue("Quantity", qty);
                cmd.ExecuteNonQuery();
            
            }
            Response.Write("<script LANGUAGE='JavaScript' >alert('Add Successful')</script>");


        


    }






}