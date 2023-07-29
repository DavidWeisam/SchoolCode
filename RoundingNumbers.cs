using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class RoundingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type the first float number: ");
            double x = double.Parse(Console.ReadLine());
             
            x = x * 10.0;
            x = x + 0.5;
            x = (int)x;
            x = x / 10.0;
            Console.WriteLine($"the number is {x}");



            Console.WriteLine("type second float number: ");
            double y = double.Parse(Console.ReadLine());

            y = y * 100.0;
            y = y + 0.5;
            y = (int)y;
            y = y / 100.0;
            Console.WriteLine($"the number is {y}");

        }
    }
}
