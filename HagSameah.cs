using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopProj
{
    internal class HagSameah
    {
        static void Main(string[] args)
        {
            LetterHet();
            LetterGimel();
            Console.WriteLine("\n\n\n");
            LetterShin();
            LetterMame();
            LetterHet();


        }

        public static void kav1()
        {
            Console.WriteLine("********");
            Console.WriteLine("********");
        }

        public static void kav2()
        {
            Console.WriteLine("      **");
            Console.WriteLine("      **");
        }
        public static void kav3()
        {
            Console.WriteLine("** ** **");
            Console.WriteLine("** ** **");
        }

        public static void kav4()
        {
            Console.WriteLine("**    **");
            Console.WriteLine("**    **");
        }

        public static void kav5()
        {
            Console.WriteLine("    ****");
            Console.WriteLine("    ****");
        }

        public static void kav6()
        {
            Console.WriteLine("**      ");
            Console.WriteLine("**      ");
        }

        public static void kav7()
        {
            Console.WriteLine("**  ****");
            Console.WriteLine("**  ****");
        }




        public static void LetterHet()
        {
            Console.ForegroundColor = (ConsoleColor)15;
            kav1();
            for (int i = 1; i <= 3; i++)
            {
                kav4();
            }

            Console.WriteLine();
        }

        public static void LetterGimel()
        {
            Console.ForegroundColor = (ConsoleColor)14;
            kav1();
            kav2();
            kav1();
            kav4();
            Console.WriteLine();
        }

        public static void LetterShin()
        {
            Console.ForegroundColor = (ConsoleColor)13;
            for (int i = 1; i <= 3; i++)
            {
                kav3();
            }

            kav1();
            Console.WriteLine();
        }
        public static void LetterMame()
        {
            Console.ForegroundColor = (ConsoleColor)12;
            kav6();
            kav1();
            kav4();
            kav4();
            kav7();

            Console.WriteLine();
        }



    }
}
