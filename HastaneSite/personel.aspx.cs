using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace HastaneSite
{
    public partial class personelform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hastane;Integrated Security=True";
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                string query = "SELECT COUNT(1) FROM HemsireTbl WHERE hemsireAd =@hemsireAd AND hemsireTcNo =@hemsireTcNo";
                SqlCommand sqlcmd = new SqlCommand(query,sqlcon);
                sqlcmd.Parameters.AddWithValue("@hemsireAd",TextUserName.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@hemsireTcNo", TextPassword.Text.Trim());
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (count ==1)
                {
                    Response.Redirect("hemsire_ekranı.aspx");
                }
                else
                {
                    query = "SELECT COUNT(1) FROM HastaBakıcı WHERE PerAd =@PerAd AND TcNo =@TcNo";
                    SqlCommand sqlcom= new SqlCommand(query, sqlcon);
                    sqlcom.Parameters.AddWithValue("@PerAd", TextUserName.Text.Trim());
                    sqlcom.Parameters.AddWithValue("@TcNo", TextPassword.Text.Trim());
                    count = Convert.ToInt32(sqlcom.ExecuteScalar());
                    if (count == 1)
                    {
                        Response.Redirect("hastabakıcı_ekranı.aspx");
                    }
                    else
                    {
                        query = "SELECT COUNT(1) FROM DoktorTbl WHERE doktorAd =@doktorAd AND doktorTcNo =@doktorTcNo";
                        SqlCommand sqlcomm = new SqlCommand(query, sqlcon);
                        sqlcomm.Parameters.AddWithValue("@doktorAd", TextUserName.Text.Trim());
                        sqlcomm.Parameters.AddWithValue("@doktorTcNo", TextPassword.Text.Trim());
                        count = Convert.ToInt32(sqlcomm.ExecuteScalar());
                        if (count == 1)
                        {
                            Response.Redirect("doktor_ekranı.aspx");
                        }
                        else
                        {

                            lblErrorMessage.Visible = true;
                            sqlcon.Close();
                        }
                    }
                }
            }

        }
    }
}