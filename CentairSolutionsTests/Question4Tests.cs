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

            var result = sorter.SortArray(initial);

            Assert.IsTrue(expeted.SequenceEqual(result), "Sequence not sorted");
        }


        [TestMethod]
        public void HappyPathProductionSort()
        {
            var sorter = new Sorter();
            int[] initial = { 5, 8, 2, -1, 0 };
            int[] expeted = { -1, 0, 2, 5, 8 };

            Assert.IsTrue(expeted.SequenceEqual(sorter.ProductionSort(initial)));
        }



        [TestMethod]
        public void HappyPathSort2()
        {
            var sorter = new Sorter();
            int[] initial = { 5, 4, 3, 2, 1, 0 };
            int[] expeted = { 0, 1, 2, 3, 4, 5 };

            var result = sorter.SortArray(initial);

            foreach (var i in result) { Console.Out.WriteLine(i); }

            Assert.IsTrue(expeted.SequenceEqual(result), "Sequence not sorted");
        }
        [TestMethod]
        public void HappyPathSort3()
        {
            var sorter = new Sorter();
            int[] initial = { 0, 1, 2, 3, 4, 5 };
            int[] expeted = { 0, 1, 2, 3, 4, 5 };

            var result = sorter.SortArray(initial);

            foreach (var i in result) { Console.Out.WriteLine(i); }

            Assert.IsTrue(expeted.SequenceEqual(result), "Sequence not sorted");
        }
        [TestMethod]
        public void HappyPathSort4()
        {
            var sorter = new Sorter();
            int[] initial = { 1, 0 };
            int[] expeted = { 0, 1 };

            var result = sorter.SortArray(initial);

            foreach (var i in result) { Console.Out.WriteLine(i); }

            Assert.IsTrue(expeted.SequenceEqual(result), "Sequence not sorted");
        }


        [TestMethod]
        public void SadPathSort()
        {
            var sorter = new Sorter();

            Assert.IsNull(sorter.SortArray(null));
        }
    }
}
