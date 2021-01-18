using Microsoft.VisualStudio.TestTools.UnitTesting;
using PandoGReact;
using PandoGReact.Logic;

namespace TestJobs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Statistics statistics = new Statistics();
            var list =Mocks.CreateFakeJobLines();
            var xxx = statistics.CalcStats(list);

        }
    }
}
