using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainPrj_NUnit;
using NUnit.Framework.Legacy;

namespace TestAccounts
{
    [TestFixture]
   public  class TestClass
   {
        Employee emp;

        [SetUp]
        public void ArrangeObjects()
        {
            emp = new Employee();
        }

        [Test]
        [Ignore("Wait for sometime")]
        public void TestingEmployeeData_for_NullValues()
        {
            List<Employee> elist = emp.Employeelist();
            foreach(var item in elist)
            {
                ClassicAssert.IsNotNull(item.Id);
                ClassicAssert.IsNotEmpty(item.Name);
            }
        }

        [Test]
        [TestCase(15,35,50)]
        [TestCase(10,45,55)]
        [TestCase(20,50,70)]
        public void Testing_Add2Nos_withParameters(int n1, int n2, int expected)
        {
            int result = emp.AddtwoNos(n1, n2);
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void Test_LoginMethod()
        {
            //act
            string s1 = emp.Login("Banurekha", "Password");
            string s2 = emp.Login("", "");
            string s3 = emp.Login("Admin", "Admin@123");

            ClassicAssert.AreEqual("Incorrect UserId or Password", s1);
            ClassicAssert.AreEqual("User Id or Password Cannot be Empty", s2);
            ClassicAssert.AreEqual("Welcome Admin", s3 );
        }

        //testing reservation cancellations

        [Test]
        public void Cancellation_ByAdmin_Returns_True()
        {
            //arrange
            var reservation = new Reservation();

            //act
            var result = reservation.Canbe_CancelledBy(new User { IsAdmin = true });

            //assert
            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void Cancellation_ByUser_Returns_True()
        {
            var user = new User();

            var reservation = new Reservation { bookedBy = user };
            var result = reservation.Canbe_CancelledBy(user);

            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void Cancellation_Madeby_Others_Returns_False()
        {
            var reservation = new Reservation() { bookedBy = new User() };
            var result = reservation.Canbe_CancelledBy(new User()); //reservation.bookedBy);
            ClassicAssert.IsFalse(result);
        }

   }
}
