using System;


namespace FirstConsole
{    
        internal class Program
        {
             static void Main()
            {
                Console.WriteLine("Hello and Welcome to Dotnet..");
                Program program = new Program();
                program.Show();
                Program p2 = new Program();
                p2.Show();

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
                    Console.WriteLine("I am Display");
                 }
              }
}
