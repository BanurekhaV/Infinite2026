using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    internal class FewPatternTypes
    {
        //public static string ConstantDayoftheWeekPattern(int day)
        //{
        //    return day switch
        //    {
        //        1 => "Sunday",
        //        2 => "Monday",

        //        _ => "Invalid Week Day"
        //    };
        //}

        ////relational pattern
        //public static string GetNumberSign(int num)
        //{
        //    // way 1 to write
        //    switch(num)
        //    {
        //        case < 0: return "Negative";
        //        case 0: return "its Zero";
        //        case >= 1: return " Positive";
        //    }

        //    //way 2

        //    return num switch
        //    {
        //         < 0 => "Negative",
        //         0 => "Zero",
        //         >0 => "Positive
        //    };
        //}

        ////property pattern
        //public static void GetStringdetails(string str)
        //{
        //    if (str is null)
        //    {
        //        Console.WriteLine("It is Null");
        //        return;
        //    }
        //    if (str is { Length: 0 })
        //    {
        //        Console.WriteLine("Empty string");
        //        return;
        //    }
        //    if (str is { Length: 1 })
        //    {
        //        Console.WriteLine("String with length 1");
        //        return;
        //    }
        //    Console.WriteLine("string greater than 1 length");
        //    return;
        //}
        //    static void Main()
        //{
        //    //Console.WriteLine(ConstantDayoftheWeekPattern(3));

        //    //int n1 = 0, n2 = -25, n3 = 12;
        //    //Console.WriteLine(GetNumberSign(n1));
        //    //GetStringdetails("Hello");
        //    //GetStringdetails("");
        //}
    }
}
