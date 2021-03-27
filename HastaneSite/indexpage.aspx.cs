using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneSite
{
    public partial class indexpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void DocImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("doktorlar.aspx");
        }

        protected void RandevuImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("randevu_alma.aspx");
        }

        protected void SorguRandevuImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("randevu_sorgulama.aspx");
        }
    }
}