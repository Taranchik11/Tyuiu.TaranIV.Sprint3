using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TaranIV.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {

            foreach (char ch in value)
            {
                if (Char.IsDigit(ch))
                {
                    value = value.Replace(ch, item);
                }
            }

            return value;
        }
    }
}