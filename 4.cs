using System;

namespace ConsoleApp25
{
    class Program
    {
        static int Factorial(int n)
        {
            int f = 1;
            for (int i = 2; i <= n; ++i)
            {
                f *= i;
            }
            return f;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число N= ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0)
            {
                Console.WriteLine(Factorial(n));
            }
            else
            {
                Console.WriteLine("Ошибка, n<0");
            }
            Console.ReadLine();
        }
    }
}
