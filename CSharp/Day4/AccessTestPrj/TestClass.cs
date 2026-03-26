using System;
using Day4;

namespace AccessTestPrj
{
    internal class TestClass : AccessSpecifiers
    {
        static void Main(string[] args)
        {
            AccessSpecifiers specifiers = new AccessSpecifiers();
            specifiers.publicdata = 30;
           
           TestClass tc = new TestClass();
           tc.protecteddata = 30;
            tc.internalprotecteddata = 35;
        }
    }
}
