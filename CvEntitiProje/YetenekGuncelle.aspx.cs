using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CvEntitiProje;

namespace CvEntitiProje
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        CV_ENTITIEntities1 dt = new CV_ENTITIEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);

            if (Page.IsPostBack == false)
            {
                var ytnk = dt.TBL_YETENEK.Find(x);
                TextBox1.Text = ytnk.YETENEK;
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var ytnk = dt.TBL_YETENEK.Find(x);
            ytnk.YETENEK = TextBox1.Text;
            dt.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}