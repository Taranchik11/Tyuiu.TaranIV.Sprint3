using Tyuiu.TaranIV.Sprint3.V8.Lib;

namespace Tyuiu.TaranIV.Sprint3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;

            double wait = -0.886281;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            Assert.AreEqual(wait, res, 0.000001);
        }
    }
}