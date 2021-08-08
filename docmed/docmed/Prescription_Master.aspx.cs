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
using System.Web.Services;

public partial class Prescription_Master : System.Web.UI.Page
{
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
        //string decs = TextBox1.Text;
        //string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        //MySqlConnection con = new MySqlConnection(constr);
        //con.Open();
        //MySqlCommand cmd = new MySqlCommand("select * from MedicineInfo where medicineName LIKE 'Ra%' ", con);
        //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //DataTable dt = new DataTable();

        //da.Fill(dt);

        //DropDownList1.DataSource = dt;
        //DropDownList1.DataTextField = "decs";
        //DropDownList1.DataValueField = "decs";
        //DropDownList1.DataBind();
        //  GridView1.Visible = false;
        {
            if (Page.IsPostBack)
            {
                if (ViewState["records"] == null)
                {
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Description");
                    dt.Columns.Add("Quantity");
                    dt.Columns.Add("Morning");
                    dt.Columns.Add("Afternoon");
                    dt.Columns.Add("Night");
                    ViewState["records"] = dt;
                    //  dt.Columns.Add("ID");
                }
            }

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string id = Request.Form["id"];
        String pName = Session["pName"].ToString();
        string decs = TextBox1.Text;
        string name = Request.Form["name"];
        DateTime.Now.ToString();
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();
        try
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into PrescriptionDetails (patientname,Description,date,pathalogyName,RFID,Morning,Afternoon,Night,Quantity)values ('" + name + "','" + decs + "','" + DateTime.Now.ToString() + "','"+pName+"','"+id+"','"+DropDownList1.Text+"','"+DropDownList2.Text+"','"+DropDownList3.Text+"','"+TextBox2.Text+"')";
            cmd.Parameters.AddWithValue("Name", name);
            cmd.Parameters.AddWithValue("Description", decs);
            cmd.Parameters.AddWithValue("date", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("pathalogyName", pName);
            cmd.Parameters.AddWithValue("RFID", id);
            cmd.Parameters.AddWithValue("Morning", DropDownList1.Text);
            cmd.Parameters.AddWithValue("Afternoon", DropDownList2.Text);
            cmd.Parameters.AddWithValue("Night", DropDownList3.Text);
            cmd.Parameters.AddWithValue("Quantity", TextBox2.Text);
            cmd.ExecuteNonQuery();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Add Successful')</script>");
        }
        catch
        {
            throw;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Request.Form["id"];
        String pName = Session["pName"].ToString();

        string decs = Request.Form["txtarea"];
        string name = Request.Form["name"];
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        MySqlDataAdapter sa = new MySqlDataAdapter("select * from Petiant where rfidNo='" + id + "'", con);
        DataTable dt = new DataTable();
        sa.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Address = dt.Rows[0][2].ToString();
          //  decs = dt.Rows[0][2].ToString();
          
            //   add = dt.Rows[0][2].ToString();



        }

    }

    protected void Button_Click(object sender, EventArgs e)
    {
        string id = Request.Form["id"];
        string name = Request.Form["name"];
        string decs = TextBox1.Text;
        DateTime.Now.ToString();
        //string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        //MySqlConnection con = new MySqlConnection(constr);
        //con.Open();
        //MySqlCommand cmd = new MySqlCommand();
        //try
        //{
        //    cmd = con.CreateCommand();
        //    cmd.CommandText = "insert into tbl_PP (RFID,MediciName,BreakFast,Lunch,Dinner,Quantity)values ('" + id + "','" + decs + "','" + DropDownList1.Text+ "','" + DropDownList2.Text + "','" + DropDownList3.Text + "','"+TextBox2.Text+"')";
        //    cmd.Parameters.AddWithValue("RFID", id);
        //    cmd.Parameters.AddWithValue("MediciName", decs);
        //    cmd.Parameters.AddWithValue("BreakFast", DropDownList1.Text);
        //    cmd.Parameters.AddWithValue("Lunch", DropDownList2.Text);
        //    cmd.Parameters.AddWithValue("Dinner", DropDownList3.Text);
        //    cmd.ExecuteNonQuery();
        //    GridView1.Visible = true;
        //    BindGrid();
        //  //  Response.Write("<script LANGUAGE='JavaScript' >alert('Add Successful')</script>");
        //}
        //catch
        //{
        //    throw;
        //}

        dt = (DataTable)ViewState["records"];
        dt.Rows.Add(id, decs, TextBox2.Text, DropDownList1.Text, DropDownList2.Text, DropDownList3.Text);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    //public void BindGrid()
    //{
    //    string id = Request.Form["id"];
    //    string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    //    string query = "SELECT * FROM tbl_PP where RFID='" + id + "' ";
    //    using (MySqlConnection con = new MySqlConnection(constr))
    //    {
    //        using (MySqlDataAdapter sda = new MySqlDataAdapter(query, con))
    //        {
    //            using (DataTable dt = new DataTable())
    //            {
    //                sda.Fill(dt);
    //                GridView1.DataSource = dt;
    //                GridView1.DataBind();
    //            }
    //        }
    //    }
    //}
}