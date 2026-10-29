using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TaranIV.Sprint3.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 1.0;

            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries *= Math.Pow(value, i) + 1;
            }


            return sumSeries * Math.Cos(4);
        }
    }
}
