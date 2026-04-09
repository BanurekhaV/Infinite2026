using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    class Accounts
    {
        public double balance;

        public Accounts(double bal)
        {
            balance = bal;
        }

        public void Credit(double amt)
        {
            balance += amt;
        }

        public void Debit(double amt)
        {
            balance -= amt; 
        }
    }
    internal class TaskPrg
    {
        static void Main(string[] args)
        {
            var account = new Accounts(1000);

            var tasks = new Task[30];
            for(int i=0; i<tasks.Length; i++)
            {
                Console.WriteLine("Going to start a task");
                tasks[i] = Task.Run(() => RandomnlyUpdateBalance(account));
            }
            Task.WaitAll(tasks);
            Console.WriteLine("all tasks done...");
            Console.WriteLine(account.balance + " " +" is the actual balance");
            TaskPrg.LiteralMovement();
            Console.Read();
        }

        static void RandomnlyUpdateBalance(Accounts accounts)
        {
            var rand = new Random();
            for(int i = 0;i < 10; i++)
            {
                var amount = rand.Next(1, 100);   //78

                bool b = rand.NextDouble() < 0.5;
                if(b)
                {
                    accounts.Credit(amount);
                }
                else
                {
                    accounts.Debit(amount);
                }
            }
        }

        static void LiteralMovement()
        {
            var lit1 = 345_6234_567_8908;   //digit separator
            long l = lit1 + 45;

            var lit2 = 0xa3_f7e_de34_f3e;  // heaxadecimal 

            var lit3 = 1100_1011_0011_0010_1110;
            Console.WriteLine($"{lit1} {l} {lit2} {lit3}");

        }
    }
}
