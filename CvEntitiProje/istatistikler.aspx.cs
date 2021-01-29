using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CvEntitiProje;

namespace CvEntitiProje
{
    public partial class istatistikler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CV_ENTITIEntities1 dt
                = new CV_ENTITIEntities1();
            Label1.Text = dt.TBL_YETENEK.Count().ToString();
            Label2.Text = dt.TBL_ILETISIM.Count().ToString();
            Label3.Text = dt.TBL_YETENEK.Average(x => x.DERECE).ToString();
            Label4.Text = dt.TBL_YETENEK.Max(x => x.DERECE).ToString();
            
        }
    }
}