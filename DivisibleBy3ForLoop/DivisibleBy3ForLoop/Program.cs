using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivisibleBy3ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Following are the numbers that are  divisible by 3:");
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) == 0)
                {
                    Console.Write("{0} ", i);
                    count++;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("From 1 to 100 total {0} numbers are divisible by 3", count);
            Console.ReadLine();
        }
    }
}

