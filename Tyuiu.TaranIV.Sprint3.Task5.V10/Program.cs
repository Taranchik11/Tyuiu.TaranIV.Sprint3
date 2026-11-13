using Tyuiu.TaranIV.Sprint3.Task5.V10.Lib;

Console.Title = "Спринт #3 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Вложенные циклы                                                   *");
Console.WriteLine("* Задание #3.5                                                            *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Вычислить уравнение при x = 5                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

int x = 5;
int startValue1 = 1;
int startValue2 = 1;
int stopValue1 = 3;
int stopValue2 = 10;

double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

Console.WriteLine($"Переменная X = {x}");
Console.WriteLine($"Старт шага первой суммы ряда = {startValue1}");
Console.WriteLine($"Конец шага первой суммы ряда = {stopValue1}");
Console.WriteLine($"Старт шага второй суммы ряда = {startValue2}");
Console.WriteLine($"Конец шага первой суммы ряда = {stopValue2}");


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Сумма ряда = {result}");

