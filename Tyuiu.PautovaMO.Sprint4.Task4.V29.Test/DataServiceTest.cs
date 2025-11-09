using Tyuiu.PautovaMO.Sprint4.Task4.V29.Lib;

namespace Tyuiu.PautovaMO.Sprint4.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 7, 5, 5, 6, 7 }, { 8, 7, 8, 4, 3 }, { 5, 6, 7, 8, 3 }, { 4, 2, 3, 6, 4 }, { 5, 2, 4, 2, 3 } };
            int res = ds.Calculate(matrix);
            int wait = 13;
            Assert.AreEqual(wait, res);
        }
    }
}
