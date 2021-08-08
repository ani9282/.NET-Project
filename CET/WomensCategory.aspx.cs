using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WomensCategory : System.Web.UI.Page
{
    public String id;
    public String id1;
    public string id2;
    public string id3;
    public string id4;
    public string id5;
    public string id6;
    public string id7;
    public string id8;
    public string id9;
    public string id10;
    public string id11;
    public String id12;
    public String id13;
    public string id14;
    public string id15;
    public string id16;
    public string id17;

    protected void Page_Load(object sender, EventArgs e)
    {







        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        if (!IsPostBack)
        {



            String cat = "New Product";

            SqlDataAdapter da9 = new SqlDataAdapter("Select * from tbl_products where ProductType='" + cat + "'", con);
            DataTable dt9 = new DataTable();
            da9.Fill(dt9);
            int length9 = dt9.Rows.Count;
            if (dt9.Rows.Count > 0)
            {

                for (int i = 0; i < length9; i++)
                {
                    if (i == 0)
                    {
                        String firsturl = dt9.Rows[i][11].ToString();
                        String secondurl = dt9.Rows[i][12].ToString();
                        id12 = dt9.Rows[i][0].ToString();

                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);

                            Image27.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');

                            Label46.Text = dt9.Rows[i][1].ToString();
                            Label47.Text = "₹" + dt9.Rows[i][2].ToString();



                        }



                    }



                    if (i == 1)
                    {
                        String firsturl = dt9.Rows[i][11].ToString();
                        String secondurl = dt9.Rows[i][12].ToString();
                        id13 = dt9.Rows[i][0].ToString();

                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);

                            Image28.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');

                            Label48.Text = dt9.Rows[i][1].ToString();
                            Label49.Text = "₹" + dt9.Rows[i][2].ToString();



                        }



                    }
                    if (i == 2)
                    {
                        String firsturl = dt9.Rows[i][11].ToString();
                        String secondurl = dt9.Rows[i][12].ToString();
                        id14 = dt9.Rows[i][0].ToString();

                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);

                            Image29.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');

                            Label50.Text = dt9.Rows[i][1].ToString();
                            Label51.Text = "₹" + dt9.Rows[i][2].ToString();



                        }



                    }



                    if (i == 3)
                    {
                        String firsturl = dt9.Rows[i][11].ToString();
                        String secondurl = dt9.Rows[i][12].ToString();
                        id15 = dt9.Rows[i][0].ToString();

                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);

                            Image30.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');

                            Label52.Text = dt9.Rows[i][1].ToString();
                            Label53.Text = "₹" + dt9.Rows[i][2].ToString();



                        }



                    }



                    if (i == 4)
                    {
                        String firsturl = dt9.Rows[i][11].ToString();
                        String secondurl = dt9.Rows[i][12].ToString();
                        id16 = dt9.Rows[i][0].ToString();

                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);

                            Image31.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');

                            Label54.Text = dt9.Rows[i][1].ToString();
                            Label55.Text = "₹" + dt9.Rows[i][2].ToString();



                        }



                    }


                    if (i == 5)
                    {
                        String firsturl = dt9.Rows[i][11].ToString();
                        String secondurl = dt9.Rows[i][12].ToString();
                        id17 = dt9.Rows[i][0].ToString();

                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);

                            Image32.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');

                            Label56.Text = dt9.Rows[i][1].ToString();
                            Label57.Text = "₹" + dt9.Rows[i][2].ToString();



                        }



                    }

                }











                String Mycurrentsession = null;

                try
                {

                    if (Session["SES"] == null)
                    {
                        Label27.Text = Convert.ToDecimal("0.00").ToString();
                        Label26.Text = "-";

                        Label29.Text = Convert.ToDecimal("0.00").ToString();
                        Label28.Text = "-";

                        Label30.Text = Convert.ToDecimal("0.00").ToString();

                    }
                    else
                    {
                        Mycurrentsession = Session["SES"].ToString();


                        SqlDataAdapter da1 = new SqlDataAdapter("select * from tblCart where Sessionid='" + Mycurrentsession + "'", con);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        int length1 = dt1.Rows.Count;
                        for (int i = 0; i < length1; i++)
                        {
                            if (i == 0)
                            {

                                Label26.Text = dt1.Rows[i][2].ToString();
                                String str = dt1.Rows[i][4].ToString();
                                String str1 = dt1.Rows[i][5].ToString();
                                Label27.Text = str + "X " + str1;
                                Image25.ImageUrl = dt1.Rows[i][7].ToString();
                                Label29.Text = Convert.ToDecimal("0.00").ToString();
                                Label28.Text = "-";
                            }

                            if (i == 1)
                            {

                                Label28.Text = dt1.Rows[i][2].ToString();
                                String str = dt1.Rows[i][4].ToString();
                                String str1 = dt1.Rows[i][5].ToString();
                                Label29.Text = str + "X " + str1;
                                Image26.ImageUrl = dt1.Rows[i][7].ToString();


                            }
                        }



                        SqlCommand cmd = new SqlCommand("Select sum(Price) from tblCart where Sessionid='" + Mycurrentsession + "'", con);
                        cmd.Connection = con;
                        decimal a = Convert.ToDecimal(cmd.ExecuteScalar().ToString());

                        Label30.Text = a.ToString();


                    }



                }
                catch (Exception ex)
                {
                    Label26.Text = Convert.ToDecimal("0.00").ToString();

                }
            }




            String Str = "Womens Wear";

            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_products where Cat_Name='" + Str + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int length = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < length; i++)
                {
                    if (i == 0)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id = dt.Rows[i][0].ToString();

                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);

                            Image1.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image2.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label1.Text = dt.Rows[i][1].ToString();
                            Label2.Text = "₹" + dt.Rows[i][2].ToString();
                            Label25.Text = dt.Rows[i][6].ToString();


                        }



                    }

                    if (i == 1)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id1 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image3.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image4.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label3.Text = dt.Rows[i][1].ToString();
                            Label4.Text = "₹" + dt.Rows[i][2].ToString();
                            Label31.Text = dt.Rows[i][6].ToString();

                        }



                    }
                    if (i == 2)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id2 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image5.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image6.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label5.Text = dt.Rows[i][1].ToString();
                            Label6.Text = "₹" + dt.Rows[i][2].ToString();
                            Label32.Text = dt.Rows[i][6].ToString();
                        }



                    }

                    if (i == 3)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id3 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image7.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image8.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label7.Text = dt.Rows[i][1].ToString();
                            Label8.Text = "₹" + dt.Rows[i][2].ToString();
                            Label33.Text = dt.Rows[i][6].ToString();

                        }



                    }

                    if (i == 4)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id4 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image9.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image10.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label9.Text = dt.Rows[i][1].ToString();
                            Label10.Text = "₹" + dt.Rows[i][2].ToString();
                            Label34.Text = dt.Rows[i][6].ToString();

                        }



                    }

                    if (i == 5)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id5 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image11.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image12.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label11.Text = dt.Rows[i][1].ToString();
                            Label12.Text = "₹" + dt.Rows[i][2].ToString();
                            Label35.Text = dt.Rows[i][6].ToString();
                        }



                    }


                    if (i == 6)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id6 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image13.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image14.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label13.Text = dt.Rows[i][1].ToString();
                            Label14.Text = "₹" + dt.Rows[i][2].ToString();
                            Label36.Text = dt.Rows[i][6].ToString();

                        }



                    }

                    if (i == 7)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id7 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image15.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image16.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label15.Text = dt.Rows[i][1].ToString();
                            Label16.Text = "₹" + dt.Rows[i][2].ToString();
                            Label37.Text = dt.Rows[i][6].ToString();

                        }



                    }


                    if (i == 8)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id8 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image17.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image18.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label17.Text = dt.Rows[i][1].ToString();
                            Label18.Text = "₹" + dt.Rows[i][2].ToString();
                            Label38.Text = dt.Rows[i][6].ToString();

                        }



                    }


                    if (i == 9)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id9 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image19.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image20.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label19.Text = dt.Rows[i][1].ToString();
                            Label20.Text = "₹" + dt.Rows[i][2].ToString();
                            Label39.Text = dt.Rows[i][6].ToString();

                        }



                    }

                    if (i == 10)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id10 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image21.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image22.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label21.Text = dt.Rows[i][1].ToString();
                            Label22.Text = "₹" + dt.Rows[i][2].ToString();
                            Label40.Text = dt.Rows[i][6].ToString();

                        }



                    }

                    if (i == 11)
                    {
                        String firsturl = dt.Rows[i][11].ToString();
                        String secondurl = dt.Rows[i][12].ToString();
                        id11 = dt.Rows[i][0].ToString();
                        string physicalPath = Convert.ToString(firsturl);
                        string imagesPhysicalPath = Server.MapPath("~/Files/");

                        if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                        {
                            string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                            Image23.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Image24.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                            Label23.Text = dt.Rows[i][1].ToString();
                            Label24.Text = "₹" + dt.Rows[i][2].ToString();
                            Label41.Text = dt.Rows[i][6].ToString();

                        }



                    }

                }

            }

            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tblFiles1", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            int length2 = dt2.Rows.Count;
            for (int i = 0; i <= length2; i++)
            {
                if (i == 0)
                {
                    Label42.Text = dt2.Rows[i][4].ToString();


                }

                if (i == 1)
                {
                    Label43.Text = dt2.Rows[i][4].ToString();


                }

            }


        }
    }
}






    

