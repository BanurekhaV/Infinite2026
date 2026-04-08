using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculatordll;

namespace CalculatorExtensionDll
{
    public static class CalculatorExtension
    {

        public static int Multiply(this Calculator c, int x, int y)
        {
            return x * y; 
        }

        public static int Divide(this Calculator c, int x, int y)
        {
            return x / y;
        }
    }
}
