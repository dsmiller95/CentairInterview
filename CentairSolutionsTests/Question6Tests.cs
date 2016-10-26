using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentairSolutions;

namespace CentairSolutionsTests
{
    [TestClass]
    public class Question6CountTests
    {


        [TestMethod]
        public void HappyPathCount()
        {
            //test every day of the week
            var counter = new WidgetCounter();
            WidgetCounter.Widget[] initial =
            {
                new WidgetCounter.Widget(new DateTime(2000, 1, 1)),
                new WidgetCounter.Widget(new DateTime(2000, 1, 2)),
                new WidgetCounter.Widget(new DateTime(2000, 1, 3)),
                new WidgetCounter.Widget(new DateTime(2000, 1, 4)),
                new WidgetCounter.Widget(new DateTime(2000, 1, 5)),
                new WidgetCounter.Widget(new DateTime(2000, 1, 6)),
                new WidgetCounter.Widget(new DateTime(2000, 1, 7))
            };
            var expected = new Dictionary<DayOfWeek, int>()
            {
                {DayOfWeek.Monday, 1},
                {DayOfWeek.Tuesday, 1},
                {DayOfWeek.Wednesday, 1},
                {DayOfWeek.Thursday, 1},
                {DayOfWeek.Friday, 1},
                {DayOfWeek.Saturday, 1},
                {DayOfWeek.Sunday, 1}
            };

            var result = counter.CountByDayOfWeek(initial);

            foreach (var key in expected.Keys)
            {
                Assert.AreEqual(expected[key], result[key]);
            }
        }
        [TestMethod]
        public void HappyPathSpecficDaysCount()
        {
            var counter = new WidgetCounter();
            WidgetCounter.Widget[] initial =
            {
                new WidgetCounter.Widget(new DateTime(2016, 10, 24)),
                new WidgetCounter.Widget(new DateTime(2016, 10, 24)),
                new WidgetCounter.Widget(new DateTime(2016, 10, 21)),
                new WidgetCounter.Widget(new DateTime(2016, 10, 21)),
                new WidgetCounter.Widget(new DateTime(2016, 10, 23)),
                new WidgetCounter.Widget(new DateTime(2016, 10, 22)),
                new WidgetCounter.Widget(new DateTime(2016, 10, 22))
            };
            var expected = new Dictionary<DayOfWeek, int>()
            {
                {DayOfWeek.Monday, 2},
                {DayOfWeek.Tuesday, 0},
                {DayOfWeek.Wednesday, 0},
                {DayOfWeek.Thursday, 0},
                {DayOfWeek.Friday, 2},
                {DayOfWeek.Saturday, 2},
                {DayOfWeek.Sunday, 1}
            };

            var result = counter.CountByDayOfWeek(initial);

            foreach (var key in expected.Keys)
            {
                Assert.AreEqual(expected[key], result[key]);
            }
        }

        [TestMethod]
        public void NonePathCount()
        {
            var counter = new WidgetCounter();
            WidgetCounter.Widget[] initial =
            {
            };
            var expected = new Dictionary<DayOfWeek, int>()
            {
                {DayOfWeek.Monday, 0},
                {DayOfWeek.Tuesday, 0},
                {DayOfWeek.Wednesday, 0},
                {DayOfWeek.Thursday, 0},
                {DayOfWeek.Friday, 0},
                {DayOfWeek.Saturday, 0},
                {DayOfWeek.Sunday, 0}
            };

            var result = counter.CountByDayOfWeek(initial);

            foreach (var key in expected.Keys)
            {
                Assert.AreEqual(expected[key], result[key]);
            }
        }

        [TestMethod]
        public void NullPathCount()
        {
            var counter = new WidgetCounter();

            Assert.IsNull(counter.CountByDayOfWeek(null));
        }
    }
}
