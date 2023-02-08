using System;
using System.Linq;

namespace NewProgram;

public class Program
{
    public static void Main()
    {
        int number = ReadInt("Введите трехзначное число: ");
        int amount = number.ToString().Length;

        if (amount < 3 || amount > 3)
        {
            Console.WriteLine("Было введено не трехзначное число, введите трехзначное.");
        }
        else
        {
            Console.WriteLine(InCenter(number));
        }

        int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        int InCenter(int a)
        {
            
            int result = ((a / 10) % 10);
            return result;
        }   
    }    
}


