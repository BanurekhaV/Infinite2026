using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests
{
    [TestClass]
    public class MSTestClass
    {
        [TestMethod]
        public void Method1()
        {
            int expected = 10, actual = 10;
            Assert.AreEqual(expected, actual);
           Console.WriteLine("Test Method 1 matched values");
        }

        [TestMethod]
        public void Method2()
        {
            Trace.WriteLine("Test Method 2");
        }

        [TestInitialize]
        public void BeforeAllTest()
        {
            Trace.WriteLine("Called before every test..");
        }

        [TestCleanup]
        public void AfterAllTest()
        {
            Debug.Print("Called after every test..");
        }

        [ClassInitialize]
        public static void Once_For_the_Entire_Class(TestContext tc)
        {
            Trace.WriteLine("Called once for the Entire class..");
        }

        [ClassCleanup]
        public static void Once_For_Disposal_Of_Class()
        {
            Trace.WriteLine("Called after the class is unloaded..");
        }

        [AssemblyInitialize]
        public static void At_the_Start_ofthe_Assembly(TestContext tc)
        {
            Trace.WriteLine("All work done once for the entire Assembly");
        }

        [AssemblyCleanup]
        public static void Atthe_End_Assembly()
        {
            Trace.WriteLine("Entire Assembly cleanup...");
        }
    }
}
