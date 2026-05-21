using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web_Services_Prj
{
    /// <summary>
    /// Summary description for TrialWebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TrialWebServices : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]        

        public string SayHello(string uname)
        {
            return "Hello " + uname;
        }

        [WebMethod]
        public float SquareRoot(float f)
        {
            return f * f;
        }

        public void Message()
        {
            Console.WriteLine("This is a non web method message");
        }
    }
}
