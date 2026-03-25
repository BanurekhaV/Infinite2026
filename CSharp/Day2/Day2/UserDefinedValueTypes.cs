using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    enum Cities { Bangalore=2, Agra=1, Chennai=3, Delhi=4,Hyderabad=6, Ghaziabad=5, Vizag=7}

    struct Student
    {
       public int Id;
       public float MathsMarks;
       public float ScienceMarks;
       public string SName;

        public void ShowStudent()
        {
            Console.WriteLine($"Id : {Id}, Name :{SName}, Maths :{MathsMarks}, Science :{ScienceMarks}");
        }
    }
    internal class UserDefinedValueTypes
    {
        public static void UnderstandEnums()
        {
            //getting values from the enum
            foreach (int item in Enum.GetValues(typeof(Cities)))
            {
                // Console.WriteLine(item);
                if (item == 2)
                    Console.WriteLine(Enum.GetName(typeof(Cities), item) + " is a Garden City");
                else if (item == 3)
                    Console.WriteLine(Enum.GetName(typeof(Cities), item) + " is a Temple City");
                else if(item == 7)
                    Console.WriteLine(Enum.GetName(typeof(Cities), item) + " is a Steel City");
                else Console.WriteLine("No details");
            }

            //getting names from the enum
            foreach (var name in Enum.GetNames(typeof(Cities)))
            {
                Console.WriteLine(name);
            }
        }
        public static void Main()
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.SName = "Hariharasudhan";
            s1.MathsMarks = 86;
            s1.ScienceMarks = 90;
            s1.ShowStudent();

            Student s2 = s1;  //equated 2 structures and hence values are copied
            Console.WriteLine("--------------------------------");
            s2.ShowStudent();

            s1.SName = "Sivaraj";
            Console.WriteLine("----------------- After changes-------------------");
            s1.ShowStudent();
            s2.ShowStudent();
            Console.WriteLine("********** Enumerations ***********");
            UnderstandEnums();

            Console.WriteLine("-----------Working with Readonly Constants-----------");
            ReadOnly_Constants.UnderstandingReadonlyConstants();
            Console.Read();
        }
    }
}
