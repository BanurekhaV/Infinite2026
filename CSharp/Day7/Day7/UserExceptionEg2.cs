using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class CustomNameException : ApplicationException
    {
        public CustomNameException(string s) : base(s) { }
    }
    internal class UserExceptionEg2
    {
        public static string res;
        public static string ChangeNameToCapitals(string name)
        {            
            try
            {
                if (name.Trim().Equals(string.Empty))
                {
                    //throw our custom exception
                    throw new CustomNameException("Name cannot be blank");
                }
                else
                    res = name.ToUpper();
            }
            catch(CustomNameException cne)
            {
                //we will rethrow the exception
                throw cne;
                //Console.WriteLine(cne.Message + " " + cne.StackTrace);            
            }
            return res;
        }

        static void Main()
        {
            string username;
            Console.WriteLine("Enter Your Name :");
            username = Console.ReadLine();

            try
            {
                string nameinCaps = ChangeNameToCapitals(username);
                Console.WriteLine($" Your Name in Capitals : {nameinCaps}");
            }
            catch(CustomNameException c)
            {
                Console.WriteLine(c.Message);
            }
            Console.Read();
        }
    }
}
