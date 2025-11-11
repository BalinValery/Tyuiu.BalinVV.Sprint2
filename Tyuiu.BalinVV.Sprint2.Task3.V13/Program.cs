using Tyuiu.BalinVV.Sprint2.Task3.V13.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил: Балин В.В. | СМАРТб-25-1";
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Вложенные операторы if - else                                           *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Балин В.В. | СМАРТб-25-1                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*Написать программу, которая вычисляет требуемое значение функции Y с испо*");
        Console.WriteLine("*ользованием вложенных оператор if-else, где пользователь вводит значение *");
        Console.WriteLine("* переменной X с клавиатуры. Округлить полученное значение до трех знаков *");
        Console.WriteLine("* после запятой;                                                          *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите x:");
        var x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        

        
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        
        
        var result = ds.Calculate(x);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}