using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace HastaneSite
{
    public partial class randevu_sorgulama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void sorgulamaBtn_Click(object sender, EventArgs e)
        {
            
           

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Hastane;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Hasta WHERE hastaID = @hastaID  ";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@hastaID",Convert.ToInt32 (TextPassword.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
            //cmd.Parameters.AddWithValue("@RandevuTbl.RandevuNo", Convert.ToInt32(TextUserName.Text.Trim()));
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds;
            int rowCount = GridView1.Rows.Count;
            GridView1.DataBind();
            rowCount = GridView1.Rows.Count;
            if (rowCount == 0)
            {
                lblErrorMessage.Text = "Yanlış TC kimlik no bilgisi girdiniz";
                lblErrorMessage.Visible = true;
            }
            con.Close();
            con.Open();
            SqlCommand cmmd = new SqlCommand();
            cmmd.CommandText = "SELECT * FROM RandevuTbl WHERE RandevuNo = @RandevuNo  ";
            cmmd.Connection = con;
            cmmd.Parameters.AddWithValue("@RandevuNo", Convert.ToInt32(TextUserName.Text.Trim()));
            SqlDataAdapter das = new SqlDataAdapter();
            das.SelectCommand = cmmd;
            //cmd.Parameters.AddWithValue("@RandevuTbl.RandevuNo", Convert.ToInt32(TextUserName.Text.Trim()));
            DataSet dss = new DataSet();
            da.Fill(dss);
            GridView2.DataSource = dss;
            int rowCount1 = GridView2.Rows.Count;
            GridView2.DataBind();
            rowCount1 = GridView2.Rows.Count;
            if (rowCount1==0)
            {
                lblErrorMessage.Text ="Yanlış RandevuNo bilgisi girdiniz";
                lblErrorMessage.Visible = true;
            }
            con.Close();
        


        }
    }
}