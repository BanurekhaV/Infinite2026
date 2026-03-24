using System;


namespace Day1
{
    internal class ProgramElements
    {
        public static void Main()
        {
            ProgramElements prgElements = new ProgramElements();
           // prgElements.CheckGrade();
           // prgElements.CheckGradewithSwitch();
           Loops loops = new Loops();
            loops.WhileLoop();
            loops.DoWhileLoop();
            loops.Forloop();
            Console.Read();
        }
        public void CheckGrade()
        {
            char grade;
            
            Console.WriteLine("Enter the Grade :");
            grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'O' || grade == 'o')
                Console.WriteLine("Outstanding");
            else if (grade == 'A' || grade == 'a')
                Console.WriteLine("Excellent");
            else if (grade == 'B' || grade == 'b')
                Console.WriteLine("Very Good");
            else if (grade == 'C' || grade == 'c')
                Console.WriteLine("To Improve");
            else Console.WriteLine("Invalid Grade");
        }

        public void CheckGradewithSwitch()
        {
            char grade;
            Console.WriteLine("Enter Grade :");
            grade= Convert.ToChar(Console.ReadLine());
            switch(grade)
            {
                case 'O':
                case 'o':
                    Console.WriteLine("Outstanding");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("excellent");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("To Improve");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }
    }

    class Loops
    {
        public void WhileLoop()
        {
            int i = 1;
            while(i<5)
            {
                Console.WriteLine(i);
                i++; 
            }
        }
        public void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }while(i<5);
        }

        public void Forloop()
        {
            int tot = 0;
                for(int i=0; i<5; i++)
                {
                if (i == 3)
                    //break;
                    continue;
                tot += i;
                }
            Console.WriteLine("Total of all numbers is " + tot);
        }
    }
}
