using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CvEntitiProje;

namespace CvEntitiProje
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CV_ENTITIEntities1 dt
                = new CV_ENTITIEntities1();
            Repeater1.DataSource = dt.TBL_YETENEK.ToList();
            Repeater1.DataBind();
        }
    }
}