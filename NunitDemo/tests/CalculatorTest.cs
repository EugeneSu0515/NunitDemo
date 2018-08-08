using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitDemo.source;
using NUnit.Framework;

namespace NunitDemo.tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Add_Input_First_1_Second_2_Return_3()
        {
            //arrange
            var target =  new Calculator();
            var firstNumber = 1;
            var secondNumber = 2;
            var expected = 3;
            //act
            var actual = target.Add(firstNumber, secondNumber);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
