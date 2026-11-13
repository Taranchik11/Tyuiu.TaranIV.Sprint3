using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TaranIV.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0 && d > 11)
                    {
                        sum += d;
                    }
                }
            }

            return sum;
        }
    }
}
