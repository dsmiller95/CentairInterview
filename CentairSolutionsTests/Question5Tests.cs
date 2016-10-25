using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentairSolutions;

namespace CentairSolutionsTests
{
    [TestClass]
    public class Question5Tests
    {


        [TestMethod]
        public void HappyPathDigitizer()
        {
            var digitizer = new Digitizer();
            string initial = "One2Three4";
            string expeted = "24";

            Assert.IsTrue(expeted.Equals(digitizer.GetDigits(initial)));
        }
    }
}
