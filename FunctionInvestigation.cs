using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class FunctionInvestigation
    {
        static void Main(string[] args)
        {




            // משתנה לתוצאה הסופית
            double x;

            // משתנה לדיסקרימיננטה 
            double d;


            // קלט מקדמי המשוואה למשתנים
            Console.WriteLine("Enter the a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the c: ");
            double c = double.Parse(Console.ReadLine());


            // בדיקה האם המשוואה היא ישאר וחישוב של התוצאה
            if (a == 0)
            {
                if (b != 0)
                    if (b < 0)
                        Console.Write($"{Math.Abs(b)}x");
                    else
                        Console.Write($"{b}x ");
                    

                if (c < 0)
                    Console.WriteLine($" - {Math.Abs(c)} = 0");
                else
                    Console.WriteLine($" + {c} = 0");

                Console.WriteLine("This is a straight line equation.");
                x = -1 * c / b;
                Console.WriteLine($"x = {x}");
                Console.WriteLine("\n\n\n");

            }



            // חישוב משוואה ריבועית
            else
            {
                if (a == 1)
                    Console.Write($"{a,20}x^2 ");
                else
                if (a == -1)
                    Console.Write(" -x^2");
                else
                    Console.Write($"{a}x^2");

                if (b < 0)
                    Console.Write($" - {Math.Abs(b)}x");
                else
                    Console.Write($" +  {b}x ");


                if (c < 0)
                    Console.WriteLine($" - {Math.Abs(c)} = 0");
                else
                    Console.WriteLine($" + {c} = 0");


                // חישוב של הדיסקרימיננטה 
                d = Math.Pow(b, 2) - 4 * a * c;


                // חישוב לפי דיסקרימיננטה שלילית
                if (d < 0)
                    Console.WriteLine("There is no solution.");

                // חישוב לפי דיסקרימיננטה  ששווה ל 0
                if (d == 0)
                {
                    x = -1 * b / 2 * a;
                    Console.WriteLine($"x = {x}");
                    Console.WriteLine("\n\n\n");
                }

                // חישוב לפי דיסקרימיננטה חיובית
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
