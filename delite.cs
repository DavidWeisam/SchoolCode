using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class delite
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number: ");
            double x = double.Parse(Console.ReadLine());

            x = x + 0.5;
            x = x * 10;
            x = (int)x / 10;

            Console.WriteLine($"the new first num is {x}");
        }
    }
}
