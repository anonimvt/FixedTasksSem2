using System;
using System.Linq;

namespace NewProgram;

public class Program
{
    public static void Main()
    {   
        Console.WriteLine("Введите число");
        int n = int.Parse(Console.ReadLine());
        int k = (int)Math.Log10(n)-2;
        Console.WriteLine(k < 0 ? "Нет третьей цифра" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
        Console.ReadLine();
    }
}