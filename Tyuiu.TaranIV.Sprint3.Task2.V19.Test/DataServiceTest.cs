using Tyuiu.TaranIV.Sprint3.Task2.V19.Lib;

namespace Tyuiu.TaranIV.Sprint3.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double wait = -0.709;
            double res = ds.GetSumSeries(startValue, stopValue);

            Assert.AreEqual(wait, res);

        }
    }
}
