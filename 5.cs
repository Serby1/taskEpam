using System;
using System.Collections.Generic;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> a = new Stack<int>();
            Console.WriteLine("Введите скобочную последовательность:");
            string str = Console.ReadLine();
            
            if (str.Length % 2 != 0) Console.WriteLine("Не является ПСП");
            else  
            {
                a.Push(0);
                for (int i = 0; i < str.Length; ++i)
                {

                    if (str[i] == '(')
                    {
                        a.Push(1);
                        continue;
                    }
                    if (str[i] == '{')
                    {
                        a.Push(2);
                        continue;
                    }

                    if (str[i] == '[')
                    {
                        a.Push(3);
                        continue;
                    }
                    if (str[i] == ')')
                    {
                        if (a.Peek() == 1) a.Pop();
                        else
                        {
                            Console.WriteLine("Не является ПСП");
                            a.Push(4);
                            break;
                        }
                    }
                    if (str[i] == '}')
                    {
                        if (a.Peek() == 2) a.Pop();
                        else
                        {
                            Console.WriteLine("Не является ПСП");
                            a.Push(4);
                            break;
                        }
                    }
                    if (str[i] == ']')
                    {
                        if (a.Peek() == 3) a.Pop();
                        else
                        {
                            Console.WriteLine("Не является ПСП");
                            a.Push(4);
                            break;
                        }
                    }

                }
                if (a.Peek() == 0) Console.WriteLine("Строка является ПСП!");
            }
            Console.ReadLine();
        }
    }
}
