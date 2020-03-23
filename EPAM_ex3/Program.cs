using System;

namespace EPAM_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            var words = str.Split(" " , StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            foreach (string word in words)
            {
                foreach (string temp in words)
                {
                    if (word == temp)
                    {
                        i++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (i == 1)
                {
                    Console.Write(word + " ");
                    i = 0;
                }
                else
                {
                    i = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
