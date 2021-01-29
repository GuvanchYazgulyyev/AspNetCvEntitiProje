using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CvEntitiProje;

namespace CvEntitiProje
{
    public partial class Default : System.Web.UI.Page
    {
        CV_ENTITIEntities1 dt = new CV_ENTITIEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            
           
                Repeater1.DataSource = dt.TBL_HAKKIMDA.ToList();
                Repeater1.DataBind();

                Repeater2.DataSource = dt.TBL_HAKKIMDA.ToList();
                Repeater2.DataBind();

                Repeater3.DataSource = dt.TBL_HAKKIMDA.ToList();
                Repeater3.DataBind();

                Repeater4.DataSource = dt.TBL_YETENEK.ToList();
                Repeater4.DataBind();
        

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
            TBL_ILETISIM t = new TBL_ILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;

            dt.TBL_ILETISIM.Add(t);
            dt.SaveChanges();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}