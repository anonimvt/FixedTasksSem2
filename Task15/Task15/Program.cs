using System;
using System.Linq;

namespace NewProgram;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите число");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 6 || input == 7)

        {
            Console.WriteLine("Да");   
        }
        else
        {
            Console.WriteLine("Нет");
        }

    }
}