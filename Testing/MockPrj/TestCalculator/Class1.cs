using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using MockPrj;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace TestCalculator
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Add_2_Nos_Returns_CorrectTotal()
        {
            //mock objects
            var mockcalculator = new Mock<ICalculator>();
            mockcalculator.Setup(s => s.Add(3,3)).Returns(6);

            //act
            var result = mockcalculator.Object.Add(3,3);

            //assert
            ClassicAssert.AreEqual(6, result);  
        }
    }
}
