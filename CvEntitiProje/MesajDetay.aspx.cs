using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CvEntitiProje;

namespace CvEntitiProje
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CV_ENTITIEntities1 dt = new CV_ENTITIEntities1();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = dt.TBL_ILETISIM.Find(x);
            TxtAdSoyad.Text = mesaj.ADSOYAD;
            TxtMail.Text = mesaj.MAIL;
            TxtKonu.Text = mesaj.KONU;
            TxtMesaj.Text = mesaj.MESAJ;
        }
    }
}