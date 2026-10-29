using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TaranIV.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1.0;

            while (startValue <= stopValue)
            {
                product *= Math.Pow(300 / (Math.Cos(value) + Math.Pow(value, startValue)), startValue);
                startValue++;
            }

            return Math.Round(product, 3) ;
        }
    }
}
