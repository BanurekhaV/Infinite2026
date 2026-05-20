using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Exception_Prj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/Employees.xml"));
                Grid1.DataSource = ds;
                Grid1.DataBind();
            //}
            //catch (Exception ex)
            //{
            //    Response.Write(ex.Message);
            //    lblstatus.Text = "Some Error Occurred.. Try later";
            //}
        }

        //handling page errors as events in the code behind file
        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex1 = Server.GetLastError();
            Server.ClearError(); // to avoid propogating the error to the application level
            Response.Write(ex1.GetType());
            Response.Redirect("~/Myerrpage.aspx");
        }
    }
}