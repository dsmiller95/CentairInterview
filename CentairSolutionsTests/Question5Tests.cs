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

        [TestMethod]
        public void SadPathDigitizer()
        {
            var digitizer = new Digitizer();
            string initial = "OneTwoThreeFour";
            string expeted = "";

            Assert.IsTrue(expeted.Equals(digitizer.GetDigits(initial)));
        }

        [TestMethod]
        public void VeryHappyPathDigitizer()
        {
            var digitizer = new Digitizer();
            string initial = "123456789012345678123456789098765432345678";
            string expeted = "123456789012345678123456789098765432345678";

            Assert.IsTrue(expeted.Equals(digitizer.GetDigits(initial)));
        }

        [TestMethod]
        public void NullPathDigitizer()
        {
            var digitizer = new Digitizer();

            Assert.IsNull(digitizer.GetDigits(null));
        }

        [TestMethod]
        public void EmptyPathDigitizer()
        {
            var digitizer = new Digitizer();
            string initial = "";
            string expeted = "";

            Assert.IsTrue(expeted.Equals(digitizer.GetDigits(initial)));
        }

    }
}
