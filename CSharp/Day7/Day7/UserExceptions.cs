using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class VotingException : ApplicationException
    {
        public VotingException(string msg) : base(msg) { }
    }

    class Vote
    {
        int age;

        public void AcceptAge()
        {
            Console.WriteLine("Enter Your Age : ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                 throw (new VotingException("Age should be greater than 18 to vote.."));
                //throw (new VotingException());
            }
            else
            {
                Console.WriteLine("Thanks for Voting..");
            }            
        }
    }
    internal class UserExceptions
    {
        static void Main()
        {
            Vote vote = new Vote();
            try
            {
                vote.AcceptAge();
            }
            catch (VotingException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
