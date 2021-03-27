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
    public partial class yatılıhasta : System.Web.UI.Page
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
                string query = "SELECT COUNT(1) FROM YatılıHasta WHERE hastaAd =@hastaAd AND OdaID =@OdaID";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                sqlcmd.Parameters.AddWithValue("@hastaAd", TextUserName.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@OdaID", TextPassword.Text.Trim());
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (count == 1)
                {
                    Response.Redirect("YatılıHastaEkranı.aspx");
                }
                else
                {
                    lblErrorMessage.Visible = true;
                }
            }
        }
    }
}