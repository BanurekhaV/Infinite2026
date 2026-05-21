using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Client
{
    public partial class ClientForm : System.Web.UI.Page
    {
        TrialServiceReference.TrialWebServicesSoapClient _soapclient =
            new TrialServiceReference.TrialWebServicesSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHello_Click(object sender, EventArgs e)
        {
            lblstatus.Text = _soapclient.HelloWorld();
        }

        protected void btnSayhello_Click(object sender, EventArgs e)
        {
            lblstatus.Text= _soapclient.SayHello(txtuname.Text);    
        }

        protected void btnsquare_Click(object sender, EventArgs e)
        {
            lblstatus.Text = _soapclient.SquareRoot(Convert.ToSingle(txtfnum.Text)).ToString();
        }
    }
}