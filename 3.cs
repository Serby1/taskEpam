using System;
using System.Linq;
namespace ConsoleApp24
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] words = str.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            var onlyWord = words.Where(x => words.Count(a => a == x) == 1);
            foreach (var w in onlyWord )
            {
                Console.WriteLine(w);
            }
            Console.ReadLine();
        }
    }
}
