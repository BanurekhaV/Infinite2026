using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crosspage_PostingDemo
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(PreviousPage !=null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox txtdname = (TextBox)PreviousPage.FindControl("txtname");
                lblname.Text = "Welcome " + txtdname.Text;
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}