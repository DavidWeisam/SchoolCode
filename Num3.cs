using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Num3
    {
        static void Main(string[] args)
        {
            int num;
            int conuter1 = 0;
            int conuter2 = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter your number: ");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                    conuter1++;
                if (num < 0)
                    conuter2++;
            }
            Console.WriteLine($"The number of postive number is: {conuter1}");
            Console.WriteLine($"The number of negative number is: {conuter2}");
        }
    }
}
