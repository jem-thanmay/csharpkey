using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Assignment2
    {
        public static void Main()
        {
            int x, y;
            Console.WriteLine("Enter First Number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine($"{y} is smaller");
            }
            else if (x > y)
            {
                Console.WriteLine($"{x} is smaller");
            }
            else
            {
                Console.WriteLine("They are Equal");
            }


        }
    }
}
