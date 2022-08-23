using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assignment
    {
        public static void Main()
        {
            int a, b, c;

            Console.Write("Enter the 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the 3rd number: ");
            c = Convert.ToInt32(Console.ReadLine());

            int result = a * b * c;
            Console.WriteLine(result);
        }
    }
}
