using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace first
{
    internal class FunctionInvestigation2
    {
        static void Main(string[] args)
        {

            // The input of the three parameters
            Console.WriteLine("Enter the a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the c: ");
            double c = double.Parse(Console.ReadLine());

            Printted(a, b, c);
            Solution(a, b, c);
        }




        // תצוגת המשוואה לפי הנקלט
        public static void Printted(double a, double b, double c)
        {
            if (a == 1)
                Console.Write("x^2");

            else
            {
                if (a == -1)
                    Console.Write("-x^2");
                if (a != 0)
                    Console.Write($"{a}x^2");
            }

            if (b < 0)
                Console.Write($"- {Math.Abs(b)}x ");

            if (b != 0)
                Console.Write($"+ {b}x ");


            if (c < 0)
                Console.WriteLine($"- {Math.Abs(c)} = 0");

            else
            {
                if (c != 0)
                    Console.WriteLine($"+ {c} = 0");

                else
                    Console.WriteLine(" = 0");
            }

          
            Console.WriteLine();
        }

        // חישוב התוצאה של המשווה
        public static void Solution(double a, double b, double c)
        {
            double x;
            double d = Math.Pow(b, 2) - 4 * a * c;
          
            if (a == 0)
            {
                if (b == 0 & c == 0)
                    Console.WriteLine("Every x");

                if (b != 0 & c == 0)
                    Console.WriteLine("x = 0");

                if (b == 0 & c != 0)
                    Console.WriteLine("there is no solution");

                if (b != 0 & c != 0)
                {
                    x = -1 * b / c;
                    Console.WriteLine($"x = {x}");
                }
            }

            else
            {
                if (d < 0)
                    Console.WriteLine("There is no solution.");

                if (d == 0)
                {
                    x = (-1 * b) / (2 * a);
                    Console.WriteLine($"x = {x}");
                    Console.WriteLine("\n\n\n");
                }

                if (d > 0)
                {
                    x = (-1 * b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"x1 = {x}");

                    x = (-1 * b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"x2 = {x}");
                }
            }
        }
        
    }
}

/*

1#
 Enter the a:
0
Enter the b:
0
Enter the c:

Every x
 
2#
Enter the a:
2
Enter the b:
9
Enter the c:
4
2x^2+ 9x + 4 = 0

x1 = -0.5
x2 = -4

3#
Enter the a:
4
Enter the b:
5
Enter the c:
2
4x^2+ 5x + 2 = 0

There is no solution.




 
 
 
 
 */