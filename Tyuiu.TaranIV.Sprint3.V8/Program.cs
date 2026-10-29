using Tyuiu.TaranIV.Sprint3.V8.Lib;

Console.Title = "Спринт #3 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                                                *");
Console.WriteLine("* Задание #3.0                                                            *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
Console.WriteLine("* ряда по формуле, при a = 0,25                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double value = 0.25;
int startValue = 1;
int stopValue = 10;
double res = ds.GetMultiplySeries(value, startValue, stopValue);

Console.WriteLine($"Переменная a = {value}");
Console.WriteLine($"Старт шага = {startValue}");
Console.WriteLine($"Конец шага = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Результат = {res}");
Console.ReadKey();