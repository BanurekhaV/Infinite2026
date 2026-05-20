using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using context = System.Web.HttpContext;

namespace Exception_Prj
{
    public static class ExceptionLogging
    {
        static string exurl;
        static SqlConnection con;

        private static void getConnection()
        {
            con = new SqlConnection("Data Source= laptop-tjj7d977; Initial Catalog=infinitedb;" +
                "integrated security=true;");
            con.Open();
        }
        public static void Log_Exception_toDB(Exception exdb)
        {
            getConnection();
            exurl = context.Current.Request.Url.ToString();
            SqlCommand cmd = new SqlCommand("ExceptionLoggingintoDB", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //add parameters
            cmd.Parameters.AddWithValue("@exceptionmsg", exdb.Message.ToString());
            cmd.Parameters.AddWithValue("@exceptiontype", exdb.GetType().Name.ToString());
            cmd.Parameters.AddWithValue("@exceptionsource", exdb.StackTrace.ToString());    
            cmd.Parameters.AddWithValue("@exceptionurl",exurl);

            cmd.ExecuteNonQuery();
        }
    }
}