using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CvEntitiProje;

namespace CvEntitiProje
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CV_ENTITIEntities1 dt
                = new CV_ENTITIEntities1();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var ytnk = dt.TBL_YETENEK.Find(x);
            dt.TBL_YETENEK.Remove(ytnk);
            dt.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}