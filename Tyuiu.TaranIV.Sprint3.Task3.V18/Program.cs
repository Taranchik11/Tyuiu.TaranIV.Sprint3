using Tyuiu.TaranIV.Sprint3.Task3.V18.Lib;

Console.Title = "Спринт #3 | Выполнил: Таран И. В. | ПКТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
Console.WriteLine("* Задание #3.3                                                            *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Таран Иван Владимирович | ПКТб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach заменить цифры на букву n в строке:4n5nvf 56 bgy *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

string str = "4n5nvf 56 bgy";
char ch = 'n';

Console.WriteLine($"Исходная строка: {str}");
Console.WriteLine($"Искомый символ: {ch}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string result = ds.ReplaceNumOnChar(str, ch);
Console.WriteLine($"Переделанная строка: {result}");

Console.ReadKey();