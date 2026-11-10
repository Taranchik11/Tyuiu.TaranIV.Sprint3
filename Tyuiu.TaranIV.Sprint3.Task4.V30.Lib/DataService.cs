using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TaranIV.Sprint3.Task4.V30.Lib
{
    public class DataService : ISprint3Task4V30
    {
        public double Calculate(int startValue, int stopValue)
        {
            double value = 0;

            for (int i = startValue; i <= stopValue; i++) 
            {
                if (i == 0)
                {
                    continue;
                }
                else 
                {
                    value += Math.Sin(i) / i;

                }
            }
            
            return Math.Round(value, 3);
        }
    }
}
