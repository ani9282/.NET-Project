using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Services;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    [WebMethod]
    public static string[] GetCustomers(string prefix)
    {
        List<string> customers = new List<string>();
        using (MySqlConnection conn = new MySqlConnection())
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "select medicineName from MedicineInfo where MedicineName like '"+prefix +"' '%'";
               
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


    protected void Submit(object sender, EventArgs e)
    {
        string customerName = Request.Form[txtSearch.UniqueID];
        string customerId = Request.Form[hfCustomerId.UniqueID];
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Name: " + customerName + "\\nID: " + customerId + "');", true);
    }
}
