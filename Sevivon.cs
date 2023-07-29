using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopProj
{
    internal class Sevivon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of spins: ");
            int n = int.Parse(Console.ReadLine());

            int count0 = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            
            Random rand = new Random();
            for (int i = 1; i <= n; i++)
            {
                int side = rand.Next(4);
                Console.Write(side + " ");

                switch (side)
                {
                    case 0:
                        count0++;
                        break;
                    case 1:
                        count1++;
                        break;
                    case 2:
                        count2++;
                        break;
                    case 3:
                        count3++;
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Num of Nes: {count0}");
            Console.WriteLine($"Num of Gadol: {count1}");
            Console.WriteLine($"Num of Haya: {count2}");
            Console.WriteLine($"Num of Po: {count3}");



            int max = count0;
            int min = count0;

            if (count1 > max)
                max = count1;
            else if (count1 < min)
                min = count1;

            if (count2 > max)
                max = count2;
            else if (count2 < min)
                min = count2;

            if (count3 > max)
                max = count3;
            else if (count3 < min)
                min = count3;

            int diff = max - min;
            double percentage = (double)diff / n;
            Console.WriteLine($"differance: {diff}");
            Console.WriteLine($"percentage: {percentage}");

            Console.WriteLine();

            if (percentage < 0.05)
                Console.WriteLine("It is good sevivon.");
            else
                Console.WriteLine("It is bad sevivon.");

            Console.WriteLine("\n\n\n");


        }
    }
}
