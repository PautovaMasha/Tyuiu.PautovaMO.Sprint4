using Tyuiu.PautovaMO.Sprint4.Task0.V29.Lib;

namespace Tyuiu.PautovaMO.Sprint4.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] arr = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.GetSumOddArrEl(arr);
            Assert.AreEqual(32, res);
        }
    }
}