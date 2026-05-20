using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exception_Prj
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //option 1
            //if(PreviousPage !=null)
            //{
            //    lblname.Text = ((TextBox)PreviousPage.FindControl("txtname")).Text;
            //    lblemail.Text = ((TextBox)PreviousPage.FindControl("txtmail")).Text;
            //}

            //option 2
            System.Collections.Specialized.NameValueCollection nvcprevious =
                Request.Form;

            lblname.Text = nvcprevious["txtname"];
            lblemail.Text= nvcprevious["txtmail"];

        }

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            Response.Write("Hi I am Web Form 2");
        }
    }
}