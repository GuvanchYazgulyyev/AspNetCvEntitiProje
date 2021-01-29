using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CvEntitiProje;

namespace CvEntitiProje
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        CV_ENTITIEntities1 dt
            = new CV_ENTITIEntities1();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_YETENEK t = new TBL_YETENEK();
            t.YETENEK = TextBox1.Text;
            dt.TBL_YETENEK.Add(t);
            dt.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}