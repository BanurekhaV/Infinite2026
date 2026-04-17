using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainPrj_NUnit;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestAccounts
{
    [TestFixture]
    public class TestingAccount
    {
        //arrange
        MainPrj_NUnit.Accounts acctobj;

        [SetUp]
        public void TestingSetUp()
        {
            acctobj = new Accounts("12345");
        }

        [Test]
        //to test depositmethod
        public void TestingDepositfor_correctBalance()
        {
             //act
            acctobj.Deposit(1000);

            ClassicAssert.AreEqual(1500, acctobj.CheckBalance());
        }

        public void TestWithdraw()
        {
            acctobj.Withdraw(2000);
        }

        [Test]
        public void TestWithdrawThrowsException()
        {
            Assert.Throws<Exception>(TestWithdraw);
        }
    }
}
