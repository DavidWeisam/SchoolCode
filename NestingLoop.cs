using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopProj
{
    internal class NestingLoop
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = (ConsoleColor)10;
            for (int s = 1; s <= 5; s++)
            {
                for (int i = 1; i <= 5; i++)
                    Console.Write(" *");

                Console.WriteLine();

            }

            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine("\n------------\n");

            Console.ForegroundColor = (ConsoleColor)11;
            for (int s = 1; s <= 5; s++)
            {
                for (int i = 1; i <= 5; i++)
                    Console.Write($" {s}");

                Console.WriteLine();

            }

            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine("\n------------\n");

            Console.ForegroundColor = (ConsoleColor)12;
            for (int s = 1; s <= 5; s++)
            {
                for (int i = 1; i <= 5; i++)
                    Console.Write($" {i}");

                Console.WriteLine();

            }

            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine("\n------------\n");

            Console.ForegroundColor = (ConsoleColor)13;
            for (int s = 1; s <= 5; s++)
            {
                for (int i = 1; i <= s; i++)
                    Console.Write($" {i}");

                Console.WriteLine();

            }

            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine("\n------------\n");

            Console.ForegroundColor = (ConsoleColor)14;
            for (int s = 1; s <= 5; s++)
            {
                for (int i = 1; i <= s; i++)
                    Console.Write($" {s}");

                Console.WriteLine();

            }

            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine("\n------------\n");

            Console.ForegroundColor = (ConsoleColor)10;
            for (int s = 1; s <= 5; s++)
            {
                for (int i = 1; i <= s; i++)
                    Console.Write(" *");

                Console.WriteLine();

            }

            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine("\n------------\n");

            Console.ForegroundColor = (ConsoleColor)11;
            for (int s = 5; s >= 0; s--)
            {
                for (int i = 1; i <= s; i++)
                    Console.Write(" *");

                Console.WriteLine();

            }

            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine("\n------------\n");

            Console.ForegroundColor = (ConsoleColor)12;
            for (int s = 5; s >= 0; s--)
            {
                for (int i = 1; i <= s; i++)
                    Console.Write($" {s}");

                Console.WriteLine();

            }

            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine("\n------------\n");

            Console.ForegroundColor = (ConsoleColor)13;
            for (int s = 5; s >= 0; s--)
            {
                for (int i = 0; i <= s - 1; i++)

                    Console.Write($" {s - i}");

                Console.WriteLine();

            }

            

        }
    }
}
