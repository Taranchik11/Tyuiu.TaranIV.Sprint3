using Tyuiu.TaranIV.Sprint3.Task4.V30.Lib;

Console.Title = "Спринт #3 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
Console.WriteLine("* Задание #3.4                                                            *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                        *");
Console.WriteLine("* вычислить значение функции y=sin(x)/x                                   *");
Console.WriteLine("* При х = 0 пропустить значение. Полученные значения суммировать.         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

int startValue = -5;
int stopValue = 5;
double result = ds.Calculate(startValue, stopValue);

Console.WriteLine($"Старт шага: {startValue}");

Console.WriteLine($"Конец шага: {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Сумма ряда: {result}");

Console.ReadKey();
