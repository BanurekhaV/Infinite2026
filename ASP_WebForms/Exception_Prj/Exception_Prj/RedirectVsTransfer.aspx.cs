using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exception_Prj
{
    public partial class RedirectVsTransfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnclick_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/Myerrpage.aspx");
            // Server.Transfer("~/Myerrpage.aspx");

           // Response.Redirect("https://www.amazon.in");
            Server.Transfer("https://www.amazon.in");
        }
    }
}