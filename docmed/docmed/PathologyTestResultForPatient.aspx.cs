using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PathologyTestResultForPatient : System.Web.UI.Page
{
    string id;
    protected string results1 { get; set; }
    protected string discription1 { get; set; }
    protected string results2 { get; set; }
    protected string discription2 { get; set; }
    protected string results3 { get; set; }
    protected string discription3 { get; set; }
    protected string results4 { get; set; }
    protected string discription4 { get; set; }
    protected string results5 { get; set; }
    protected string discription5 { get; set; }
    protected string results6 { get; set; }
    protected string discription6 { get; set; }
    protected string results7 { get; set; }
    protected string discription7 { get; set; }
    protected string results8 { get; set; }
    protected string discription8 { get; set; }
    protected string results9 { get; set; }
    protected string discription9 { get; set; }
    protected string results10 { get; set; }
    protected string discription10 { get; set; }
    protected string results11 { get; set; }
    protected string discription11 { get; set; }
    protected string results12 { get; set; }
    protected string discription12 { get; set; }
    protected string results13 { get; set; }
    protected string discription13 { get; set; }
    protected string results14 { get; set; }
    protected string discription14 { get; set; }
    protected string results15 { get; set; }
    protected string discription15 { get; set; }
    protected string results16 { get; set; }
    protected string discription16 { get; set; }
    protected string results17 { get; set; }
    protected string discription17 { get; set; }
    protected string results18 { get; set; }
    protected string discription18 { get; set; }
    protected string results19 { get; set; }
    protected string discription19 { get; set; }
    protected string results20 { get; set; }
    protected string discription20 { get; set; }
    protected string results21 { get; set; }
    protected string discription21 { get; set; }
    protected string results22 { get; set; }
    protected string discription22 { get; set; }
    protected string results23 { get; set; }
    protected string discription23 { get; set; }
    protected string results24 { get; set; }
    protected string discription24 { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        //string id = TextBox1.Text;
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con = new MySqlConnection(constr);
        con.Open();
        if (Session["patientusername"] == null)
        {
            Response.Redirect("~/index.html");
        }

        string constr26 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con26 = new MySqlConnection(constr26);
        con26.Open();
        MySqlDataAdapter sa26 = new MySqlDataAdapter("select * from Petiant where email='" + Session["patientusername"] + "'", con26);
        DataTable dt26 = new DataTable();
        sa26.Fill(dt26);
        if (dt26.Rows.Count > 0)
        {
            id = dt26.Rows[0][1].ToString();

        }



        string constr1 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr1);
        MySqlDataAdapter sa1 = new MySqlDataAdapter("select * from Whitebloodcell  where rfid='" + id + "' order by id desc limit 1", con1);
        DataTable dt1 = new DataTable();
        sa1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            string str1 = dt1.Rows[0][2].ToString();
            discription1 = dt1.Rows[0][3].ToString();
            results1 = str1;
            float flt1 = float.Parse(str1);
            int int1 = int.Parse(str1);
            if (flt1 < 3.8 || int1 > 11000)
            {
                alert1.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert1.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con2 = new MySqlConnection(constr1);
        MySqlDataAdapter sa2 = new MySqlDataAdapter("select * from Redbloodcell  where rfid='" + id + "' order by id desc limit 1", con2);

        DataTable dt2 = new DataTable();
        sa2.Fill(dt2);
        if (dt2.Rows.Count > 0)
        {
            string str2 = dt2.Rows[0][2].ToString();
            discription2 = dt2.Rows[0][3].ToString();
            results2 = str2;
            float flt2 = float.Parse(str2);
            Int64 int2 = Int64.Parse(str2);
            if (flt2 < 4.8 || int2 > 5600000)
            {
                alert2.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert2.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr3 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con3 = new MySqlConnection(constr3);
        MySqlDataAdapter sa3 = new MySqlDataAdapter("select * from Hemoglobin  where rfid='" + id + "' order by id desc limit 1", con3);
        DataTable dt3 = new DataTable();
        sa3.Fill(dt3);
        if (dt3.Rows.Count > 0)
        {
            string str3 = dt3.Rows[0][2].ToString();
            discription3 = dt3.Rows[0][3].ToString();
            results3 = str3;
            int int31 = int.Parse(str3);
            int int3 = int.Parse(str3);
            if (int31 < 11 || int3 > 18)
            {
                alert3.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert3.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr4 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con4 = new MySqlConnection(constr4);
        MySqlDataAdapter sa4 = new MySqlDataAdapter("select * from Hematocrit  where rfid='" + id + "'order by id desc limit 1", con4);
        DataTable dt4 = new DataTable();
        sa4.Fill(dt4);
        if (dt4.Rows.Count > 0)
        {
            string str4 = dt4.Rows[0][2].ToString();
            discription4 = dt4.Rows[0][3].ToString();
            results4 = str4;
            int int32 = int.Parse(str4);
            int int4 = int.Parse(str4);
            if (int32 < 39 || int4 > 54)
            {
                alert4.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert4.BackColor = System.Drawing.Color.Green;
            }
        }

        string constr5 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con5 = new MySqlConnection(constr5);
        MySqlDataAdapter sa5 = new MySqlDataAdapter("select * from Meancorpuscularvolume  where rfid='" + id + "' order by id desc limit 1", con5);
        DataTable dt5 = new DataTable();
        sa5.Fill(dt5);
        if (dt5.Rows.Count > 0)
        {
            string str5 = dt5.Rows[0][2].ToString();
            discription5 = dt5.Rows[0][3].ToString();
            results5 = str5;
            int int33 = int.Parse(str5);
            int int5 = int.Parse(str5);
            if (int33 < 80 || int5 > 100)
            {
                alert5.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert5.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr6 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con6 = new MySqlConnection(constr6);
        MySqlDataAdapter sa6 = new MySqlDataAdapter("select * from Plateletcount  where rfid='" + id + "' order by id desc limit 1", con6);
        DataTable dt6 = new DataTable();
        sa6.Fill(dt6);
        if (dt6.Rows.Count > 0)
        {
            string str6 = dt6.Rows[0][2].ToString();
            discription6 = dt6.Rows[0][3].ToString();
            results6 = str6;
            Int32 int34 = Int32.Parse(str6);
            Int32 int6 = Int32.Parse(str6);
            if (int34 < 140000 || int6 > 450000)
            {
                alert6.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert6.BackColor = System.Drawing.Color.Green;
            }
        }

        string constr7 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con7 = new MySqlConnection(constr7);
        MySqlDataAdapter sa7 = new MySqlDataAdapter("select * from sodium  where rfid='" + id + "' order by id desc limit 1", con7);
        DataTable dt7 = new DataTable();
        sa7.Fill(dt7);
        if (dt7.Rows.Count > 0)
        {
            string str7 = dt7.Rows[0][2].ToString();
            discription7 = dt7.Rows[0][3].ToString();
            results7 = str7;
            int int35 = int.Parse(str7);
            int int7 = int.Parse(str7);
            if (int35 < 30 || int7 > 280)
            {
                alert7.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert7.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr8 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con8 = new MySqlConnection(constr8);
        MySqlDataAdapter sa8 = new MySqlDataAdapter("select * from Potassium  where rfid='" + id + "' order by id desc limit 1", con8);
        DataTable dt8 = new DataTable();
        sa8.Fill(dt8);
        if (dt8.Rows.Count > 0)
        {
            string str8 = dt8.Rows[0][2].ToString();
            discription8 = dt8.Rows[0][3].ToString();
            results8 = str8;
            int int36 = int.Parse(str8);
            int int8 = int.Parse(str8);
            if (int36 < 35 || int8 > 85)
            {
                alert8.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert8.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr9 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con9 = new MySqlConnection(constr9);
        MySqlDataAdapter sa9 = new MySqlDataAdapter("select * from Chloride  where rfid='" + id + "' order by id desc limit 1", con9);
        DataTable dt9 = new DataTable();
        sa9.Fill(dt9);
        if (dt9.Rows.Count > 0)
        {
            string str9 = dt9.Rows[0][2].ToString();
            discription9 = dt9.Rows[0][3].ToString();
            results9 = str9;
            int int37 = int.Parse(str9);
            int int9 = int.Parse(str9);
            if (int37 < 110 || int9 > 250)
            {
                alert9.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert9.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr10 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con10 = new MySqlConnection(constr10);
        MySqlDataAdapter sa10 = new MySqlDataAdapter("select * from Carbondioxide  where rfid='" + id + "' order by id desc limit 1", con10);
        DataTable dt10 = new DataTable();
        sa10.Fill(dt10);
        if (dt10.Rows.Count > 0)
        {
            string str10 = dt10.Rows[0][2].ToString();
            discription10 = dt10.Rows[0][3].ToString();
            results10 = str10;
            int int38 = int.Parse(str10);
            int int10 = int.Parse(str10);
            if (int38 < 23 || int10 > 29)
            {
                alert10.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert10.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr11 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con11 = new MySqlConnection(constr11);
        MySqlDataAdapter sa11 = new MySqlDataAdapter("select * from Bloodureanitrogen  where rfid='" + id + "' order by id desc limit 1", con11);
        DataTable dt11 = new DataTable();
        sa11.Fill(dt11);
        if (dt11.Rows.Count > 0)
        {
            string str11 = dt11.Rows[0][2].ToString();
            discription11 = dt11.Rows[0][3].ToString();
            results11 = str11;
            int int39 = int.Parse(str11);
            int int11 = int.Parse(str11);
            if (int39 < 10 || int11 > 22)
            {
                alert11.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert11.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr12 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con12 = new MySqlConnection(constr11);
        MySqlDataAdapter sa12 = new MySqlDataAdapter("select * from Creatinine  where rfid='" + id + "' order by id desc limit 1", con12);
        DataTable dt12 = new DataTable();
        sa12.Fill(dt12);
        if (dt12.Rows.Count > 0)
        {
            string str12 = dt12.Rows[0][2].ToString();
            discription12 = dt12.Rows[0][3].ToString();
            results12 = str12;
            int int40 = int.Parse(str12);
            int int12 = int.Parse(str12);
            if (int40 < 1 || int12 > 2)
            {
                alert12.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert12.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr13 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con13 = new MySqlConnection(constr13);
        MySqlDataAdapter sa13 = new MySqlDataAdapter("select * from Glucose  where rfid='" + id + "' order by id desc limit 1", con13);
        DataTable dt13 = new DataTable();
        sa13.Fill(dt13);
        if (dt13.Rows.Count > 0)
        {
            string str13 = dt13.Rows[0][2].ToString();
            discription13 = dt13.Rows[0][3].ToString();
            results13 = str13;
            int int41 = int.Parse(str13);
            int int13 = int.Parse(str13);
            if (int41 < 40 || int13 > 85)
            {
                alert13.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert13.BackColor = System.Drawing.Color.Green;
            }
        }



        string constr14 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con14 = new MySqlConnection(constr14);
        MySqlDataAdapter sa14 = new MySqlDataAdapter("select * from Calcium  where rfid='" + id + "' order by id desc limit 1", con14);
        DataTable dt14 = new DataTable();
        sa14.Fill(dt14);
        if (dt14.Rows.Count > 0)
        {
            string str14 = dt14.Rows[0][2].ToString();
            discription14 = dt14.Rows[0][3].ToString();
            results14 = str14;
            int int42 = int.Parse(str14);
            int int14 = int.Parse(str14);
            if (int42 < 8 || int14 > 11)
            {
                alert14.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert14.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr15 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con15 = new MySqlConnection(constr14);
        MySqlDataAdapter sa15 = new MySqlDataAdapter("select * from Totalprotein  where rfid='" + id + "' order by id desc limit 1", con15);
        DataTable dt15 = new DataTable();
        sa15.Fill(dt15);
        if (dt15.Rows.Count > 0)
        {
            string str15 = dt15.Rows[0][2].ToString();
            discription15 = dt15.Rows[0][3].ToString();
            results15 = str15;
            int int43 = int.Parse(str15);
            int int15 = int.Parse(str15);
            if (int43 < 5 || int15 > 9)
            {
                alert15.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert15.BackColor = System.Drawing.Color.Green;
            }
        }



        string constr16 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con16 = new MySqlConnection(constr16);
        MySqlDataAdapter sa16 = new MySqlDataAdapter("select * from Albumin  where rfid='" + id + "' order by id desc limit 1", con16);
        DataTable dt16 = new DataTable();
        sa16.Fill(dt16);
        if (dt16.Rows.Count > 0)
        {
            string str16 = dt16.Rows[0][2].ToString();
            discription16 = dt16.Rows[0][3].ToString();
            results16 = str16;
            float flt16 = float.Parse(str16);
            float flt17 = float.Parse(str16);
            if (flt16 < 3.5 || flt17 > 5.0)
            {
                alert16.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert16.BackColor = System.Drawing.Color.Green;
            }
        }



        string constr17 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con17 = new MySqlConnection(constr17);
        MySqlDataAdapter sa17 = new MySqlDataAdapter("select * from Bilirubin  where rfid='" + id + "' order by id desc limit 1", con17);
        DataTable dt17 = new DataTable();
        sa17.Fill(dt17);
        if (dt17.Rows.Count > 0)
        {
            string str17 = dt17.Rows[0][2].ToString();
            discription17 = dt17.Rows[0][3].ToString();
            results17 = str17;
            float flt17 = float.Parse(str17);
            float flt18 = float.Parse(str17);
            if (flt17 < 0.2 || flt18 > 1.4)
            {
                alert17.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert17.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr18 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con18 = new MySqlConnection(constr18);
        MySqlDataAdapter sa18 = new MySqlDataAdapter("select * from Alkalinephosphatase  where rfid='" + id + "' order by id desc limit 1", con18);
        DataTable dt18 = new DataTable();
        sa18.Fill(dt18);
        if (dt18.Rows.Count > 0)
        {
            string str18 = dt18.Rows[0][2].ToString();
            discription18 = dt18.Rows[0][3].ToString();
            results18 = str18;
            int int44 = int.Parse(str18);
            int int18 = int.Parse(str18);
            if (int44 < 32 || int18 > 110)
            {
                alert18.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert18.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr19 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con19 = new MySqlConnection(constr19);
        MySqlDataAdapter sa19 = new MySqlDataAdapter("select * from ast  where rfid='" + id + "' order by id desc limit 1", con19);
        DataTable dt19 = new DataTable();
        sa19.Fill(dt19);
        if (dt19.Rows.Count > 0)
        {
            string str19 = dt19.Rows[0][2].ToString();
            discription19 = dt19.Rows[0][3].ToString();
            results19 = str19;
            int int45 = int.Parse(str19);
            int int19 = int.Parse(str19);
            if (int45 < 7 || int19 > 21)
            {
                alert19.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert19.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr20 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con20 = new MySqlConnection(constr20);
        MySqlDataAdapter sa20 = new MySqlDataAdapter("select * from alttest  where rfid='" + id + "' order by id desc limit 1", con20);
        DataTable dt20 = new DataTable();
        sa20.Fill(dt20);
        if (dt20.Rows.Count > 0)
        {
            string str20 = dt20.Rows[0][2].ToString();
            discription20 = dt20.Rows[0][3].ToString();
            results20 = str20;
            int int46 = int.Parse(str20);
            int int20 = int.Parse(str20);
            if (int46 < 29 || int20 > 33)
            {
                alert20.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert20.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr21 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con21 = new MySqlConnection(constr21);
        MySqlDataAdapter sa21 = new MySqlDataAdapter("select * from totalcholesterol where rfid='" + id + "' order by id desc limit 1", con21);
        DataTable dt21 = new DataTable();
        sa21.Fill(dt21);
        if (dt21.Rows.Count > 0)
        {
            string str21 = dt21.Rows[0][2].ToString();
            discription21 = dt21.Rows[0][3].ToString();
            results21 = str21;
            int int21 = int.Parse(str21);
            if (int21 < 200)
            {
                alert21.BackColor = System.Drawing.Color.Green;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;

                alert21.BackColor = System.Drawing.Color.Red;
            }
        }



        string constr22 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con22 = new MySqlConnection(constr22);
        MySqlDataAdapter sa22 = new MySqlDataAdapter("select * from hdl where rfid='" + id + "' order by id desc limit 1", con22);
        DataTable dt22 = new DataTable();
        sa22.Fill(dt22);
        if (dt22.Rows.Count > 0)
        {
            string str22 = dt22.Rows[0][2].ToString();
            discription22 = dt22.Rows[0][3].ToString();
            results22 = str22;
            int int47 = int.Parse(str22);
            int int22 = int.Parse(str22);
            if (int47 < 30 || int22 > 75)
            {
                alert22.BackColor = System.Drawing.Color.Red;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;

                alert22.BackColor = System.Drawing.Color.Green;
            }
        }


        string constr23 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con23 = new MySqlConnection(constr23);
        MySqlDataAdapter sa23 = new MySqlDataAdapter("select * from ldl where rfid='" + id + "' order by id desc limit 1", con23);
        DataTable dt23 = new DataTable();
        sa23.Fill(dt23);
        if (dt23.Rows.Count > 0)
        {
            string str23 = dt23.Rows[0][2].ToString();
            discription23 = dt23.Rows[0][3].ToString();
            results23 = str23;
            int int23 = int.Parse(str23);
            if (int23 < 130)
            {
                alert23.BackColor = System.Drawing.Color.Green;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;

                alert23.BackColor = System.Drawing.Color.Red;
            }
        }


        string constr24 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        MySqlConnection con24 = new MySqlConnection(constr24);
        MySqlDataAdapter sa24 = new MySqlDataAdapter("select * from Triglycerides where rfid='" + id + "' order by id desc limit 1", con24);
        DataTable dt24 = new DataTable();
        sa24.Fill(dt24);
        if (dt24.Rows.Count > 0)
        {
            string str24 = dt24.Rows[0][2].ToString();
            discription24 = dt24.Rows[0][3].ToString();
            results24 = str24;
            int int24 = int.Parse(str24);
            if (int24 == 170)
            {
                alert24.BackColor = System.Drawing.Color.Green;
                // alert1.Text = "Please Enter Password";

            }
            else
            {
                //alert1.ForeColor= System.Drawing.Color.Green;
                alert24.BackColor = System.Drawing.Color.Red;

            }
        }



    }




   
}