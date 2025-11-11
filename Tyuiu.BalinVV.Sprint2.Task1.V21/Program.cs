using Tyuiu.BalinVV.Sprint2.Task1.V21.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 696;
        int b = 987;
        int c = 696;
        int d = 155;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        Console.Title = "Спринт #2 | Выполнила: Балин В.В. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки в C#                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Балин В.В. | СМАРТб-25-1                                     *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]); 
        }
        Console.ReadKey();
    }
}