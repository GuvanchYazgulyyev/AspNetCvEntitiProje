using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CvEntitiProje;

namespace CvEntitiProje
{
    public partial class iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CV_ENTITIEntities1 dt
                = new CV_ENTITIEntities1();
            var mesajlar = dt.TBL_ILETISIM.ToList();
            Repeater1.DataSource = mesajlar;
            Repeater1.DataBind();
        }
    }
}