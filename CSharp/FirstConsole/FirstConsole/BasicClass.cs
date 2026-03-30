using System;


namespace FirstConsole
{    
        internal class Program
        {
             static void Main()
            {
            
                Console.WriteLine("Hello and Welcome to Dotnet..");
                //Program program = new Program();
                //program.Show();
                //Program p2 = new Program();
                //p2.Show();
                //Print();
            //calling static functions/methods of another class
                Second.Display();
                Console.Read();
            }

          static void Print()  // class function that needs no objects
          {
            Console.WriteLine("This is print");
          }
           public void Show()   // instance function , that need object
           {
            Console.WriteLine("This is Show");
           }
        }
    class Second

    {
        public static void Display()

        {
            Console.Write("Enter your First Name :");
            string fname = Console.ReadLine();
            Console.Write("Enter your Last Name :");
            string lname = Console.ReadLine();
            Console.WriteLine("Your First Name is : " + fname + "and your Last Name is :" + lname);  // concatenation
            Console.WriteLine("Your First name is :{0} and your Last Name is {1}", fname,lname); //placeholder
            Console.WriteLine($"Your Name is :{fname} and your Last name is {lname} ");  // string interpolation
        }
    }

}
