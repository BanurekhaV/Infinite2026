using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace MSTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trace.WriteLine("Method 1..");
        }

        [TestMethod]
        public void Method2()
        {
            string expected = "Hi";
            string actual = expected;
            Assert.AreSame(expected, actual);
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
