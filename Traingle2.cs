using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Traingle2
    {
        static void Main(string[] args)
        {
            double pa;
            double pb;
            double pc;
            double ma;
            double mb;
            double mc;
            double p;
            double s;

            Console.Write("enter the first side: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("enter the second side: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("enter the thotd side: ");
            int c = int.Parse(Console.ReadLine());


            p = (a + c + b) / 2.0;

            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));


            pa = Math.Pow(a, 2);
            pb = Math.Pow(b, 2);
            pc = Math.Pow(c, 2);

    

            ma = Math.Sqrt((2 * pb + 2 * pc - pa) / 4);
            mb = Math.Sqrt((2 * pa + 2 * pc - pb) / 4);
            mc = Math.Sqrt((2 * pa + 2 * pb - pc) / 4);


            Console.WriteLine($"the area of the traingle is: {s}");
            Console.WriteLine($"the megian of side a is: {ma} ");
            Console.WriteLine($"the megian of side b is: {mb}");
            Console.WriteLine($"the megian of side c is: {mc}");




        }

    }
}
