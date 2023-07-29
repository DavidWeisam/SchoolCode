using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class TraingelSpeshel
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first side: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second side: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third side: ");
            double c = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
                Console.WriteLine("The three numbers does'nt match.");

            else
            { 
                if (b + c <= a && a + c <= b && a + b <= c)
                    Console.WriteLine("The three numbers does'nt match.");

                else
                {
                    if (a == c && a == b) 
                        Console.WriteLine("An isosceles trianlge");

                    if (b == c || a == c || a == b) 
                        Console.WriteLine("Equilateral triangle");

                    else
                        Console.WriteLine("scalene triangle");
                    
                    if (c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2)) || a == Math.Sqrt(Math.Pow(c, 2) + Math.Pow(b, 2)))
                        Console.WriteLine("right triangle");

                }
            }






        }

    }
}
