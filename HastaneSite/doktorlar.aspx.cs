using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace HastaneSite
{
   
    public partial class doktorlar : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;
            if (!Page.IsPostBack)
            {
                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hastane;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select doktorUnvan,doktorAd,doktorSoyad,doktorEposta FROM DoktorTbl";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                table.Append("<table border= '2' style=\"; margin-left:auto; margin-right:auto; \">");
                table.Append("<tr><th></th><th>Ünvan</th><th>İsim</th><th>Soyisim</th><th>İletişim</th></tr>");
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        i++;
                        table.Append("<tr>");
                        
                        table.Append("<td><img src=\"Properties/images/doc1.jpg\" border=3 height=100 width=100/></td>");
                        
                        table.Append("<td>" + rd[0] + "</td>");
                        table.Append("<td>" + rd[1] + "</td>");
                        table.Append("<td>" + rd[2] + "</td>");
                        table.Append("<td>" + rd[3] + "</td>");
                        table.Append("</tr>");
                    }
                }
                table.Append("</table>");
                PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
                rd.Close();
            }
            
        }
    }
}