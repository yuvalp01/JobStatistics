using Microsoft.VisualStudio.TestTools.UnitTesting;
using PandoGReact;
using PandoGReact.Logic;
using System;

namespace TestJobs
{
    [TestClass]
    public class TestStatisticsCalc
    {
        [TestMethod]
        public void TestNumberOfDates()
        {
            Statistics statistics = new Statistics();
            var list =Mocks.CreateFakeJobLines();
            var result = statistics.CalcStats(list);

            Assert.AreEqual(9, result.Count);

        }
        [TestMethod]
        public void TestJobInactiveNotCount()
        {
            Statistics statistics = new Statistics();
            var list = Mocks.CreateFakeJobLines();
            var result = statistics.CalcStats(list);
            Assert.AreEqual(4, result[new DateTime(2020, 5, 4)]);
        }
        [TestMethod]
        public void TestJob2JobsSameDay()
        {
            Statistics statistics = new Statistics();
            var list = Mocks.CreateFakeJobLines();
            var result = statistics.CalcStats(list);
            Assert.AreEqual(8, result[new DateTime(2020, 5, 9)]);
        }
    }
}
