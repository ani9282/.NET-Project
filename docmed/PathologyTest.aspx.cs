
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PathologyTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["pName"] == null)
        {
            Response.Redirect("~/index.html");
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int count = 0;
        string rfid = TextBox1.Text;
        string str =Request.Form["ch1"];
        string str2 = Request.Form["ch2"];
        string str3 = Request.Form["ch3"];
        string str4 = Request.Form["ch4"];
        string str5 = Request.Form["ch5"];
        string str6 = Request.Form["ch6"];
        string str7 = Request.Form["ch7"];
        string str8 = Request.Form["ch8"];
        string str9 = Request.Form["ch9"];
        string str10 = Request.Form["ch10"];
        string str11 = Request.Form["ch11"];
        string str12= Request.Form["ch12"];
        string str13= Request.Form["ch13"];
        string str14 = Request.Form["ch14"];
        string str15 = Request.Form["ch15"];
        string str16 = Request.Form["ch16"];
        string str17 = Request.Form["ch17"];
        string str18 = Request.Form["ch18"];
        string str19 = Request.Form["ch19"];
        string str20 = Request.Form["ch20"];
        string str21 = Request.Form["ch21"];
        string str22 = Request.Form["ch22"];
        string str23 = Request.Form["ch23"];
        string str24 = Request.Form["ch24"];
       
        if (str=="on")  //ethe tur zali tar value janar databasae la 
        {
            count++;
            string required = Request.Form["required1"];
            string results = Request.Form["results1"];
            string discription = Request.Form["discription1"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Whitebloodcell(required,results,discription,rfid) values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
           

        }

         if (str2 == "on")
        {
            count++;
            string required = Request.Form["required2"];
            string results = Request.Form["results2"];
            string discription = Request.Form["discription2"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Redbloodcell(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
            

        }

        if (str3 == "on")
        {
            count++;
            string required = Request.Form["required3"];
            string results = Request.Form["results3"];
            string discription = Request.Form["discription3"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Hemoglobin(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();


        }

        if (str4 == "on")
        {
            count++;
            string required = Request.Form["required4"];
            string results = Request.Form["results4"];
            string discription = Request.Form["discription4"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Hematocrit(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();


        }

        if (str5 == "on")
        {
            count++;
            string required = Request.Form["required5"];
            string results = Request.Form["results5"];
            string discription = Request.Form["discription5"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Meancorpuscularvolume(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();


        }

        if (str6 == "on")
        {
            count++;
            string required = Request.Form["required6"];
            string results = Request.Form["results6"];
            string discription = Request.Form["discription6"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Plateletcount(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str7 == "on")
        {
            count++;
            string required = Request.Form["required7"];
            string results = Request.Form["results7"];
            string discription = Request.Form["discription7"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into sodium(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str8 == "on")
        {
            count++;
            string required = Request.Form["required8"];
            string results = Request.Form["results8"];
            string discription = Request.Form["discription8"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Potassium(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str9 == "on")
        {
            count++;
            string required = Request.Form["required9"];
            string results = Request.Form["results9"];
            string discription = Request.Form["discription9"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Chloride(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str10 == "on")
        {
            count++;
            string required = Request.Form["required10"];
            string results = Request.Form["results10"];
            string discription = Request.Form["discription10"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Carbondioxide(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str11 == "on")
        {
            count++;
            string required = Request.Form["required11"];
            string results = Request.Form["results11"];
            string discription = Request.Form["discription11"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Bloodureanitrogen(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str12 == "on")
        {
            count++;
            string required = Request.Form["required12"];
            string results = Request.Form["results12"];
            string discription = Request.Form["discription12"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Creatinine(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str13 == "on")
        {
            count++;
            string required = Request.Form["required13"];
            string results = Request.Form["results13"];
            string discription = Request.Form["discription13"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Glucose(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str14 == "on")
        {
            count++;
            string required = Request.Form["required14"];
            string results = Request.Form["results14"];
            string discription = Request.Form["discription14"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Calcium(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str15 == "on")
        {
            count++;
            string required = Request.Form["required15"];
            string results = Request.Form["results15"];
            string discription = Request.Form["discription15"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Totalprotein(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str16 == "on")
        {
            count++;
            string required = Request.Form["required16"];
            string results = Request.Form["results16"];
            string discription = Request.Form["discription16"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Albumin(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str17 == "on")
        {
            count++;
            string required = Request.Form["required17"];
            string results = Request.Form["results17"];
            string discription = Request.Form["discription17"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Bilirubin(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str18 == "on")
        {
            count++;
            string required = Request.Form["required18"];
            string results = Request.Form["results18"];
            string discription = Request.Form["discription18"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Alkalinephosphatase(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str19 == "on")
        {
            count++;
            string required = Request.Form["required19"];
            string results = Request.Form["results19"];
            string discription = Request.Form["discription19"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into ast(required,results,discription,rfid) values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str20 == "on")
        {
            count++;
            string required = Request.Form["required20"];
            string results = Request.Form["results20"];
            string discription = Request.Form["discription20"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into alttest(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str21 == "on")
        {
            count++;
            string required = Request.Form["required21"];
            string results = Request.Form["results21"];
            string discription = Request.Form["discription21"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into totalcholesterol(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str22 == "on")
        {
            count++;
            string required = Request.Form["required22"];
            string results = Request.Form["results22"];
            string discription = Request.Form["discription22"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into hdl(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str23 == "on")
        {
            count++;
            string required = Request.Form["required23"];
            string results = Request.Form["results23"];
            string discription = Request.Form["discription23"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into ldl(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (str24 == "on")
        {
            count++;
            string required = Request.Form["required24"];
            string results = Request.Form["results24"];
            string discription = Request.Form["discription24"];
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into Triglycerides(required,results,discription,rfid)values ('" + required + "','" + results + "','" + discription + "','" + rfid + "')";
            //cmd.Parameters.AddWithValue("check", check);
            cmd.Parameters.AddWithValue("required", required);
            cmd.Parameters.AddWithValue("results", results);
            cmd.Parameters.AddWithValue("discription", discription);
            cmd.Parameters.AddWithValue("rfid", rfid);
            cmd.ExecuteNonQuery();
        }

        if (count == 0)
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Please Select One Of The Test')</script>");
        }

        if(count>0)
        {
            //Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successful)</script>");
            Response.Write("<script LANGUAGE='JavaScript' >alert('Successfully Saved')</script>");
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
           // TextBox3.Text = dt.Rows[0][3].ToString();
           // TextBox4.Text = dt.Rows[0][4].ToString();
            TextBox5.Text = dt.Rows[0][5].ToString();
            TextBox6.Text = dt.Rows[0][6].ToString();
            TextBox7.Text = dt.Rows[0][7].ToString();
            TextBox8.Text = dt.Rows[0][8].ToString();
            TextBox9.Text = dt.Rows[0][9].ToString();
            TextBox10.Text = dt.Rows[0][10].ToString();

        }
    }

}