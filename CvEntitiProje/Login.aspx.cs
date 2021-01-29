using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CvEntitiProje;

namespace CvEntitiProje
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        CV_ENTITIEntities1 dt
            = new CV_ENTITIEntities1();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in dt.TBL_ADMIN
                        where x.KULLANICIAD == TextBox1.Text && x.SIFRE == TextBox2.Text
                        select x;
            if (sorgu.Any())
            {
                Response.Redirect("iletisim.aspx");
            }
            else
            {
                Response.Write("HATALI KULLANICI ADI VEYA ŞİFRE!!!");
            }
        }
    }
}