using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tddCalApp.Library;

namespace TddCalApp.Test
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void ShouldReturnPositiveonPassingTwoPositiveNumbers()
        {
            Calculator testCalculator = new Calculator();
            int num1 = 3;
            int num2 = 4;
            int result;
            result = testCalculator.add(num1, num2);
            Assert.AreEqual(7, result, "Test two Integers 3 and 4");
           
        }


        [TestMethod]
        public void ShouldReturnZeroonPassingEqualMagnitudeandEqualSignedNumbers()
        {
            Calculator testCalculator = new Calculator();
            int num1 = 3;
            int num2 = -3;
            int result;
            result = testCalculator.add(num1, num2);
            Assert.AreEqual(0, result, "Test two Integers 3 and 4");

        }
    }
}
