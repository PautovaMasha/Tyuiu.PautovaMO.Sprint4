using Tyuiu.PautovaMO.Sprint4.Task7.V26.Lib;

namespace Tyuiu.PautovaMO.Sprint4.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string value = "351268459614723";
            int n = 5;
            int m = 3;
            int res = ds.Calculate(n, m, value);
            int wait = 18432; // 2 * 6 * 8 * 4 * 6 * 4 * 2 * 2
            Assert.AreEqual(wait, res);
        }
    }
}
