using Tyuiu.BalinVV.Sprint2.Task7.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Балин В.В. | СМАРТб-25-1";
        Console.WriteLine("###########################################################################");
        Console.WriteLine("# Спринт #2                                                               #");
        Console.WriteLine("# Тема: Оператор switch                                                   #");
        Console.WriteLine("# Задание #7                                                              #");
        Console.WriteLine("# Вариант #1                                                              #");
        Console.WriteLine("# Выполнил Балин В.В. | СМАРТб-25-1                                       #");
        Console.WriteLine("###########################################################################");
        Console.WriteLine("# УСЛОВИЕ:                                                                #");
        Console.WriteLine("# Написать программу на C#,которая запрашивает исходные данные и вычесляет#");
        Console.WriteLine("#находится ли точка с координатами X,Y в заштрихованной области.          #");
        Console.WriteLine("# день не високосного года, в котором 1 января понедельник.               #");
        Console.WriteLine("###########################################################################");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение переменной Х:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной Y:");
        double y = Convert.ToDouble(Console.ReadLine());
        DataService ds = new DataService();

        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не находится в заштрихованной области");
        }
        Console.ReadKey();

    }
}