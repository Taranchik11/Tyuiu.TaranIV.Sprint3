using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TaranIV.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double product = 0;

            do
            {
                product += Math.Cos(startValue) * 1 / 2;
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(product, 3);
        }
    }
}
