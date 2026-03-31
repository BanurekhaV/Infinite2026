using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class GradingSystem
    {
        //variable for understanding checked and unchecked
        static int maxInt = 2147483647;
        public static string GradeCalculator(int score)
        {
            if (score > 0)
            {
                if (score >= 90 && score <= 100)
                {
                    return "A";
                }
                else if (score <= 89 && score >= 70)
                {
                    return "B";
                }
                else
                {
                    return "C";
                }
            }
            else
            {
                throw new ScoreException("Score has to be greater than 0");                
            }
        }

        //example for checked and unchecked exceptions
       
        //1. checked expression

        static int CheckOverflow()
        {
            int x = 0;
            try
            {
                //the following line raises an exception
                x = checked(maxInt + 10);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("CHECKED : " + oe.ToString());
            }
            return x;  // x is 0
        }

        static int UnCheckOverflow()
        {
            int x = 0;
            try
            {
                //the following line avoids an exception
                x = maxInt + 10;
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("UNCHECKED : " + oe.ToString());
            }
            return x;  // overflow is supressed, and hence x will be -2147483639
        }
        static void Main()
        {
            try
            {
                //GradingSystem gs = new GradingSystem();
                //Console.WriteLine("Enter your Score :");
                //int score = Convert.ToInt32(Console.ReadLine());
                //string grade = GradeCalculator(score);
                //Console.WriteLine("Your Grade is : {0}", grade);
            }
            catch(ScoreException se) 
            {
                 Console.WriteLine(se.Message);
            }
            Console.WriteLine("----------Checked and Unchecked------------");
            Console.WriteLine("\n Checked Output :{0} ", CheckOverflow());
            Console.WriteLine("\n UnChecked Output :{0} ", UnCheckOverflow());
            Console.Read();
        }
    }

    class ScoreException : ApplicationException
    {
        public ScoreException(string message) : base(message) { }
    }
}
