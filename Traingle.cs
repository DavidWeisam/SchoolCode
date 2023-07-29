using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Traingle
    {
        static void Main(string[] args)
        {
            // משתנה למחצית עיקף המשולש
            double p;

            // משתנה לשטח המשולש
            double s;

            // משתנים לריבוע של צלעות המשולש
            double pa;
            double pb;
            double pc;

            // משתנים לתיכוני צלעות המשולש
            double ma;
            double mb;
            double mc;



            // קלט אורכי צלעות המשושלש
            Console.Write($"Enter the first side: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second side: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the thotd side: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n");


            // חישוב מחצית עיקף המשולש
            p = (a + c + b) / 2.0;

            // חישוב שטח המשולש לפי משפט הרון
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // חישוב של ריבוע צלעות המשולש
            pa = Math.Pow(a, 2);
            pb = Math.Pow(b, 2);
            pc = Math.Pow(c, 2);


            // חישוב תיכוני המשולש
            ma = Math.Sqrt((2 * pb + 2 * pc - pa) / 4);
            mb = Math.Sqrt((2 * pa + 2 * pc - pb) / 4);
            mc = Math.Sqrt((2 * pa + 2 * pb - pc) / 4);


            // פלט שטח המשולש
            Console.WriteLine($"The area is: {s}");

            // פלט תיכוני המשולש
            Console.WriteLine($"The megian of side a is: {ma} ");
            Console.WriteLine($"The megian of side b is: {mb}");
            Console.WriteLine($"The megian of side c is: {mc}");


            /*
             * 
            Enter the first side: 3
            Enter the second side: 4
            Enter the thotd side: 5




            The area is: 6
            The megian of side a is: 4.27200187265877
            The megian of side b is: 3.60555127546399
            The megian of side c is: 2.5
                          
             */
















        }
    }
}
