using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

public partial class IndividualProductPage : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        if (!IsPostBack)
        {
           
            String Mycurrentsession = null;

            try
            {

                if (Session["SES"] == null)
                {
                    Label11.Text = Convert.ToDecimal("0.00").ToString();
                    Label10.Text = "-";

                    Label13.Text = Convert.ToDecimal("0.00").ToString();
                    Label12.Text = "-";

                    Label14.Text = Convert.ToDecimal("0.00").ToString();

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

                            Label10.Text = dt1.Rows[i][2].ToString();
                            String str = dt1.Rows[i][4].ToString();
                            String str1 = dt1.Rows[i][5].ToString();
                            Label11.Text = str + "X " + str1;
                            Image3.ImageUrl = dt1.Rows[i][7].ToString();
                            Label13.Text = Convert.ToDecimal("0.00").ToString();
                            Label12.Text = "-";
                        }

                        if (i == 1)
                        {

                            Label12.Text = dt1.Rows[i][2].ToString();
                            String str = dt1.Rows[i][4].ToString();
                            String str1 = dt1.Rows[i][5].ToString();
                            Label13.Text = str + "X " + str1;
                            Image4.ImageUrl = dt1.Rows[i][7].ToString();


                        }
                    }



                    SqlCommand cmd = new SqlCommand("Select sum(Price) from tblCart where Sessionid='" + Mycurrentsession + "'", con);
                    cmd.Connection = con;
                    decimal a = Convert.ToDecimal(cmd.ExecuteScalar().ToString());

                    Label14.Text = a.ToString();


                }



            }
            catch (Exception ex)
            {
                Label10.Text = Convert.ToDecimal("0.00").ToString();

            }







            String ID=null;
            if (Request.QueryString["ID"] != null && Request.QueryString["ID"] != string.Empty)
               ID= Request.QueryString["ID"];
           

            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_products where PID='" + ID + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >0)
            {
                String firsturl = dt.Rows[0][11].ToString();
                String secondurl = dt.Rows[0][12].ToString();
                String thirdurl = dt.Rows[0][13].ToString();
                String fourthurl = dt.Rows[0][14].ToString();
                String fifthurl = dt.Rows[0][15].ToString();
                String Type = dt.Rows[0][7].ToString();

                String name = dt.Rows[0][1].ToString();
                String dprice = dt.Rows[0][9].ToString();
                String oprice= "₹" + dt.Rows[0][2].ToString();
                String discount = dt.Rows[0][10].ToString();
                String description = dt.Rows[0][6].ToString();
                string physicalPath = Convert.ToString(firsturl);
                string imagesPhysicalPath = Server.MapPath("~/Files/");

                String physicalPath1 = Convert.ToString(secondurl);
                String physicalpath2 = Convert.ToString(thirdurl);
                String physicalpath3 = Convert.ToString(fourthurl);
                String physicalpath4 = Convert.ToString(fifthurl);


               








                if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                {
                    string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);

                    Image1.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
                    Label1.Text = name;
                    Label8.Text = "₹";
                    Label2.Text = dprice;
                    Label3.Text = oprice;
                    Label4.Text = discount  + "% OFF";
                    Label5.Text = description;
                    Label6.Text = description;
                    Label7.Text = description;

                    if (physicalPath1.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                    {

                        String path = physicalPath1.Substring(imagesPhysicalPath.Length);
                        Image5.ImageUrl = "~/Files/" + path.Replace('\\', '/');
                    }


                    if (physicalpath2.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                    {

                        String path = physicalpath2.Substring(imagesPhysicalPath.Length);
                        Image6.ImageUrl = "~/Files/" + path.Replace('\\', '/');
                    }



                    if (physicalpath3.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                    {

                        String path = physicalpath3.Substring(imagesPhysicalPath.Length);
                        Image7.ImageUrl = "~/Files/" + path.Replace('\\', '/');
                    }


                    if (physicalpath4.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                    {

                        String path = physicalpath4.Substring(imagesPhysicalPath.Length);
                        Image8.ImageUrl = "~/Files/" + path.Replace('\\', '/');
                    }

                }


                SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_products where Cat_Name='" + Type + "' AND NOT PID='"+ID+"' ", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                int lengh = dt1.Rows.Count;
                if (dt1.Rows.Count > 0)
                {
                   
                    for (int i = 0; i <= lengh; i++)
                    {
                        
                            if (i == 0)
                            {
                                String fiurl = dt1.Rows[i][11].ToString();
                                String seurl = dt1.Rows[i][12].ToString();
                                String pPath1 = Convert.ToString(fiurl);
                                String ppath2 = Convert.ToString(seurl);

                            if (pPath1.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                            {

                                String path = pPath1.Substring(imagesPhysicalPath.Length);
                                Image9.ImageUrl = "~/Files/" + path.Replace('\\', '/');


                                String path1 = ppath2.Substring(imagesPhysicalPath.Length);
                                Image10.ImageUrl = "~/Files/" + path1.Replace('\\', '/');

                                Label17.Text = dt1.Rows[i][1].ToString();
                                Label18.Text = "₹" + dt1.Rows[i][2].ToString();
                            }

                            }
                            if (i == 1)
                            {

                            String fiurl = dt1.Rows[i][11].ToString();
                            String seurl = dt1.Rows[i][12].ToString();
                            String pPath1 = Convert.ToString(fiurl);
                            String ppath2 = Convert.ToString(seurl);

                            if (pPath1.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                            {

                                String path = pPath1.Substring(imagesPhysicalPath.Length);
                                Image11.ImageUrl = "~/Files/" + path.Replace('\\', '/');


                                String path1 = ppath2.Substring(imagesPhysicalPath.Length);
                                Image12.ImageUrl = "~/Files/" + path1.Replace('\\', '/');

                                Label19.Text = dt1.Rows[i][1].ToString();
                                Label20.Text = "₹" + dt1.Rows[i][2].ToString();
                            }



                        }



                        if (i == 2)
                        {

                            String fiurl = dt1.Rows[i][11].ToString();
                            String seurl = dt1.Rows[i][12].ToString();
                            String pPath1 = Convert.ToString(fiurl);
                            String ppath2 = Convert.ToString(seurl);

                            if (pPath1.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                            {

                                String path = pPath1.Substring(imagesPhysicalPath.Length);
                                Image13.ImageUrl = "~/Files/" + path.Replace('\\', '/');


                                String path1 = ppath2.Substring(imagesPhysicalPath.Length);
                                Image14.ImageUrl = "~/Files/" + path1.Replace('\\', '/');

                                Label21.Text = dt1.Rows[i][1].ToString();
                                Label22.Text = "₹" + dt1.Rows[i][2].ToString();
                            }



                        }




                        if (i == 3)
                        {

                            String fiurl = dt1.Rows[i][11].ToString();
                            String seurl = dt1.Rows[i][12].ToString();
                            String pPath1 = Convert.ToString(fiurl);
                            String ppath2 = Convert.ToString(seurl);

                            if (pPath1.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                            {

                                String path = pPath1.Substring(imagesPhysicalPath.Length);
                                Image15.ImageUrl = "~/Files/" + path.Replace('\\', '/');


                                String path1 = ppath2.Substring(imagesPhysicalPath.Length);
                                Image16.ImageUrl = "~/Files/" + path1.Replace('\\', '/');

                                Label23.Text = dt1.Rows[i][1].ToString();
                                Label24.Text = "₹" + dt1.Rows[i][2].ToString();
                            }



                        }
                        if (i == 4)
                        {

                            String fiurl = dt1.Rows[i][11].ToString();
                            String seurl = dt1.Rows[i][12].ToString();
                            String pPath1 = Convert.ToString(fiurl);
                            String ppath2 = Convert.ToString(seurl);

                            if (pPath1.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                            {

                                String path = pPath1.Substring(imagesPhysicalPath.Length);
                                Image17.ImageUrl = "~/Files/" + path.Replace('\\', '/');


                                String path1 = ppath2.Substring(imagesPhysicalPath.Length);
                                Image18.ImageUrl = "~/Files/" + path1.Replace('\\', '/');

                                Label25.Text = dt1.Rows[i][1].ToString();
                                Label26.Text = "₹" + dt1.Rows[i][2].ToString();
                            }



                        }
                        if (i == 5)
                        {

                            String fiurl = dt1.Rows[i][11].ToString();
                            String seurl = dt1.Rows[i][12].ToString();
                            String pPath1 = Convert.ToString(fiurl);
                            String ppath2 = Convert.ToString(seurl);

                            if (pPath1.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
                            {

                                String path = pPath1.Substring(imagesPhysicalPath.Length);
                                Image19.ImageUrl = "~/Files/" + path.Replace('\\', '/');


                                String path1 = ppath2.Substring(imagesPhysicalPath.Length);
                                Image20.ImageUrl = "~/Files/" + path1.Replace('\\', '/');

                                Label27.Text = dt1.Rows[i][1].ToString();
                                Label28.Text = "₹" + dt1.Rows[i][2].ToString();
                            }



                        }













                    }





                }


                



            }

            if (Session["val"] == null)
            {


            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", false);
                Session.Remove("val");

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
                Label15.Text = dt2.Rows[i][4].ToString();


            }

            if (i == 1)
            {
                Label16.Text = dt2.Rows[i][4].ToString();


            }

        }


    }





    protected void Button1_Click(object sender, EventArgs e)
    {


        Session["val"] = "true";

        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        String s = Request.Form["gender1"];
        String productid = null;

        String id = Session.SessionID;
        Session["SES"] = id;
        if (Request.QueryString["ID"] != null && Request.QueryString["ID"] != string.Empty)
            productid = Request.QueryString["ID"];

        String name = Label1.Text;
        String Size = s;
        string sentence = Label2.Text;

        


        decimal price = Convert.ToDecimal(sentence);
        int quantity = Convert.ToInt32(Request.Form["quantity"]);

     

        decimal finalprice = price * quantity;

    
     

        SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_products where PID='" + productid + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            String a = null;
            String firsturl = dt.Rows[0][11].ToString();
           

            string physicalPath = Convert.ToString(firsturl);
            string imagesPhysicalPath = Server.MapPath("~/Files/");

            if (physicalPath.StartsWith(imagesPhysicalPath, StringComparison.OrdinalIgnoreCase))
            {
                string relativePath = physicalPath.Substring(imagesPhysicalPath.Length);
                 a= "~/Files/" + relativePath.Replace('\\', '/');


                Image2.ImageUrl = "~/Files/" + relativePath.Replace('\\', '/');
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into tblCart values('" + id + "','" + productid + "','" + name + "','" + Size + "','" + quantity + "','" + price + "','" + finalprice + "','" + a + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label9.Text = name;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
         

            String Mycurrentsession = null;

            try
            {

                if (Session["SES"] == null)
                {
                    Label11.Text = Convert.ToDecimal("0.00").ToString();
                    Label10.Text = "-";

                    Label13.Text = Convert.ToDecimal("0.00").ToString();
                    Label12.Text = "-";

                    Label14.Text = Convert.ToDecimal("0.00").ToString();

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

                            Label10.Text = dt1.Rows[i][2].ToString();
                            String str = dt1.Rows[i][4].ToString();
                            String str1 = dt1.Rows[i][5].ToString();
                            Label11.Text = str + "X " + str1;
                            Image3.ImageUrl = dt1.Rows[i][7].ToString();
                            Label13.Text = Convert.ToDecimal("0.00").ToString();
                            Label12.Text = "-";
                        }

                        if (i == 1)
                        {

                            Label12.Text = dt1.Rows[i][2].ToString();
                            String str = dt1.Rows[i][4].ToString();
                            String str1 = dt1.Rows[i][5].ToString();
                            Label13.Text = str + "X " + str1;
                            Image4.ImageUrl = dt1.Rows[i][7].ToString();


                        }
                    }



                    SqlCommand cmd1 = new SqlCommand("Select sum(Price) from tblCart where Sessionid='" + Mycurrentsession + "'", con);
                    cmd1.Connection = con;
                    decimal a1 = Convert.ToDecimal(cmd1.ExecuteScalar().ToString());

                    Label14.Text = a1.ToString();


                }



            }
            catch (Exception ex)
            {
                Label10.Text = Convert.ToDecimal("0.00").ToString();

            }


        }
    }
}