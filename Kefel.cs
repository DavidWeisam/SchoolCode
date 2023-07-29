using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace ForLoopProj
{
    internal class Kefel
    {
        static void Main(string[] args)
        {
            //משתנה לקביע הרווחים בין המספר לעמודות בטבלה
            int m;

            // משתנה לבנית השורות בטבלה
            string kav = "+-----";

            // קלט למספר השורות והעמודות
            Console.WriteLine("Enter how many lines:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter how many columns:");
            int y = int.Parse(Console.ReadLine());

            // לולאה בשביל למקם את הכותרת בעמצא 
            Console.ForegroundColor = (ConsoleColor)13;
            for (int b = 1; b <= (y * 2); b++)
                Console.Write(" ");
            Console.WriteLine("Multiply Board");

            // לולאת קינון בשביל לבנות את הטבלה עם המספרים
            for (int s = 1; s <= x; s++)
            {
                //לולאה לשורות של הטבלה
                Console.ForegroundColor = (ConsoleColor)11;
                for (int k = 1; k <= y; k++)
                    Console.Write(kav);
                Console.WriteLine("+");


                //ללולאה למספרים ולקווים שבטבלה
                for (int i = 1; i <= y; i++)
                {
                    // הרווחים משתנים לפי המספרים אם הם דו או חד ספרתיים
                    m = s * i;
                    if (m < 10)
                    {
                        if (s == 1)
                        {
                            Console.ForegroundColor = (ConsoleColor)11;
                            Console.Write("|  ");
                            Console.ForegroundColor = (ConsoleColor)13;
                            Console.Write(m + "  ");
                            Console.ForegroundColor = (ConsoleColor)11;
                        }
                        else
                        {
                            if (i == 1)
                            {
                                Console.ForegroundColor = (ConsoleColor)11;
                                Console.Write("|  ");
                                Console.ForegroundColor = (ConsoleColor)13;
                                Console.Write(m + "  ");
                            }
                            else
                            {
                                Console.ForegroundColor = (ConsoleColor)11;
                                Console.Write("|  ");
                                Console.ForegroundColor = (ConsoleColor)10;
                                Console.Write(m + "  ");
                                Console.ForegroundColor = (ConsoleColor)11;
                            }
                        }



                    }
                    else if (m < 100)
                    {
                        if (s == 1)
                        {
                            Console.ForegroundColor = (ConsoleColor)11;
                            Console.Write("| ");
                            Console.ForegroundColor = (ConsoleColor)13;
                            Console.Write(m + "  ");
                            Console.ForegroundColor = (ConsoleColor)11;
                        }
                        else
                        {
                            if (i == 1)
                            {
                                Console.ForegroundColor = (ConsoleColor)11;
                                Console.Write("| ");
                                Console.ForegroundColor = (ConsoleColor)13;
                                Console.Write(m + "  ");
                            }
                            else
                            {
                                Console.ForegroundColor = (ConsoleColor)11;
                                Console.Write("| ");
                                Console.ForegroundColor = (ConsoleColor)10;
                                Console.Write(m + "  ");
                                Console.ForegroundColor = (ConsoleColor)11;
                            }
                        }
                    }
                    else
                    {
                        if (s == 1)
                        {
                            Console.ForegroundColor = (ConsoleColor)11;
                            Console.Write("|   ");
                            Console.ForegroundColor = (ConsoleColor)13;
                            Console.Write(m + " ");
                            Console.ForegroundColor = (ConsoleColor)11;
                        }
                        else
                        {
                            if (i == 1)
                            {
                                Console.ForegroundColor = (ConsoleColor)11;
                                Console.Write("| ");
                                Console.ForegroundColor = (ConsoleColor)13;
                                Console.Write(m + "  ");
                            }
                            else
                            {
                                Console.ForegroundColor = (ConsoleColor)11;
                                Console.Write("| ");
                                Console.ForegroundColor = (ConsoleColor)10;
                                Console.Write(m + " ");
                                Console.ForegroundColor = (ConsoleColor)11;
                            }


                        }
                    }
                }
                Console.Write("|");

                Console.WriteLine();

            }
            // לולאה לשורה האחרונה בטבלה
            for (int k = 1; k <= y; k++)
                Console.Write(kav);
            Console.WriteLine("+");
        }
    }
}
/*
 *
Enter how many lines:
7
Enter how many columns:
5
          Multiply Board
+-----+-----+-----+-----+-----+
|  1  |  2  |  3  |  4  |  5  |
+-----+-----+-----+-----+-----+
|  2  |  4  |  6  |  8  | 10  |
+-----+-----+-----+-----+-----+
|  3  |  6  |  9  | 12  | 15  |
+-----+-----+-----+-----+-----+
|  4  |  8  | 12  | 16  | 20  |
+-----+-----+-----+-----+-----+
|  5  | 10  | 15  | 20  | 25  |
+-----+-----+-----+-----+-----+
|  6  | 12  | 18  | 24  | 30  |
+-----+-----+-----+-----+-----+
|  7  | 14  | 21  | 28  | 35  |
+-----+-----+-----+-----+-----+
 
 
 
 
 */
