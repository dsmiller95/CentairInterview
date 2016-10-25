using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentairSolutions;

namespace CentairSolutionsTests
{
    [TestClass]
    public class Question4SortTests
    {


        [TestMethod]
        public void HappyPathSort()
        {
            var sorter = new Sorter();
            int[] initial = {5, 8, 2, -1, 0};
            int[] expeted = {-1, 0, 2, 5, 8};

            Assert.IsTrue(expeted.SequenceEqual(sorter.SortArray(initial)));
        }


        [TestMethod]
        public void HappyPathNiaveSort()
        {
            var sorter = new Sorter();
            int[] initial = { 5, 8, 2, -1, 0 };
            int[] expeted = { -1, 0, 2, 5, 8 };

            Assert.IsTrue(expeted.SequenceEqual(sorter.NiaveSort(initial)));
        }
    }
}
