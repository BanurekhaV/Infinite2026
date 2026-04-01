using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
   public delegate void EmpDelegate(string s); //declaration of a delegate

    delegate int NumberChanger(int n);

    class DelegatesEg2
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MulNum(int p)
        {
            num *= p;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
    }
    internal class DelegatesEg1
    {
        public static void AcceptUser(string userName)
        {
            Console.WriteLine("Hello " + userName);
        }

        public void DisplayUser(string message)
        {
             Console.WriteLine(message); 
        }

        public void GetUser()
        {
            Console.WriteLine("Getting User Details.....");
        }
    }

    class TestDelegate
    {
        static void Main()
        {
            DelegatesEg1 deleg1 = new DelegatesEg1();
            EmpDelegate ed1 = new EmpDelegate(DelegatesEg1.AcceptUser);
            EmpDelegate ed2 = new EmpDelegate(deleg1.DisplayUser);
            ed1.Invoke("Radha");  // calling the actual function thru a delegate
            ed1("Krishna");

            ed2("Giriraj Sivaraj");

            Console.WriteLine("-------------------------------------");

            NumberChanger nc1 = new NumberChanger(DelegatesEg2.AddNum);
            NumberChanger nc2 = new NumberChanger(DelegatesEg2.MulNum);

            nc1(25);
            Console.WriteLine("Value of Num : {0}", DelegatesEg2.getNum());
            nc2(5);
            Console.WriteLine("Value of Num : {0}", DelegatesEg2.getNum());
            Console.Read();

        }        
       
    }
}
