using System;
using System.Linq;

namespace EPAM_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            var words = str.Split(" " , StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words.Where(w => words.Count(v => v == w) == 1))
            {
                Console.Write(word + " ");
            }

            Console.ReadLine();
        }
    }
}
