using Tyuiu.TaranIV.Sprint3.Task6.V8.Lib;


Console.Title = "Спринт #3 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
Console.WriteLine("* Задание #3.6                                                            *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
Console.WriteLine("* принадлежащих числовому отрезку [18, 28] сумму всех делителей больше 11 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

int startValue = 18;
int stopValue = 28;

int result = ds.GetSumTheDivisors(startValue, stopValue);

Console.WriteLine($"Старт шага: {startValue}");
Console.WriteLine($"Конец шага: {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Сумма делителей: {result}");