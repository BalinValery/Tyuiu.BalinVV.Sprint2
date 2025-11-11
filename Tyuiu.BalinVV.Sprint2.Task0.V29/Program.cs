using Tyuiu.BalinVV.Sprint2.Task0.V29.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 105;
        int y = 735;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        Console.Title = "Спринт #1 | Выполнил: Балин В.В. | СМАРТб-25-1";
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
        Console.WriteLine("* Спринт #2" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #0" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
        Console.WriteLine("* Вариант 29" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
        Console.WriteLine("* Выполнил: Балин В.В. | СМАРТб-25-1" + String.Concat(Enumerable.Repeat(" ", 38)) + "*");
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
        Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
        Console.WriteLine("* Написать програму, которая сравнивает значения, и добовляет их в массив *");
        
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

        Console.WriteLine("x = 105, y = 735");

        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
        Console.WriteLine("* Результат:" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
        Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}