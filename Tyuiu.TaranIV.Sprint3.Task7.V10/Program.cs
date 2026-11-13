using Tyuiu.TaranIV.Sprint3.Task7.V10.Lib;


Console.Title = "Спринт #3 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Вложенные циклы                                                   *");
Console.WriteLine("* Задание #3.7                                                            *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функций            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

int startValue = -5;
int stopValue = 5;

Console.WriteLine($"Старт шага: {startValue}");
Console.WriteLine($"Конец шага: {stopValue}");

int len = ds.GetMassFunction(startValue, stopValue).Length;

double[] valueArray;
valueArray = new double[len];

valueArray = ds.GetMassFunction(startValue,stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("+----------+----------+");
Console.WriteLine("|    X     |   f(X)   |");
Console.WriteLine("+----------+----------+");
for (int i = 0; i <= len -1; i++)
{
    Console.WriteLine("|{0, 5:d}     |   {1, 5:f2} |", startValue, valueArray[i]);
    startValue++;
}
Console.WriteLine("+----------+----------+");
Console.ReadKey();
