using Tyuiu.PautovaMO.Sprint4.Task1.V27.Lib;

namespace Tyuiu.PautovaMO.Sprint4.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] arr = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.Calculate(arr);
            int wait = 256;
            Assert.AreEqual(wait, res);
        }
    }
}