using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopProj
{
    internal class Kefel2
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
                    m = s * i;
                    //חלוקת הרווחים לפי מספרים חד ספרתיים
                    if (m < 10)
                    {
                        //האחרי לשורה הראשונה להיות מודגשת
                        if (s == 1)
                        {
                            Mone(m,i,s);
                            Console.ForegroundColor = (ConsoleColor)11;
                        }

                        else
                        {
                            if (i == 1)
                                Mone(m,i,s);

                            else
                            {
                                Mone(m, i,s);
                                Console.ForegroundColor = (ConsoleColor)11;
                            }
                        }



                    }
                    else if (m < 100)
                    {

                        if (i == 1)
                            Mtwo(m, i);

                        else
                        {
                            Mtwo(m, i);

                            Console.ForegroundColor = (ConsoleColor)11;
                        }
                    }
                    else
                    {
                       
                        
                        if (i == 1)
                            Mthree(m, i);
                            
                        else
                        {
                            Mthree(m, i);
                            Console.ForegroundColor = (ConsoleColor)11;
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

        public static void Mone(int m, int i, int s)
        {
            int x = 10;
            if (i == 1 || s== 1)
                x = 13;
            Console.ForegroundColor = (ConsoleColor)11;
            Console.Write("|  ");
            Console.ForegroundColor = (ConsoleColor)x;
            Console.Write(m + "  ");
            if (i == 1 || s == 1)
                x = 10;
                Console.ForegroundColor = (ConsoleColor)x;



        }
        public static void Mtwo(int m, int i)
        {
            int x = 10;
            if (i == 1)
                x = 10;
            Console.ForegroundColor = (ConsoleColor)11;
            Console.Write("| ");
            Console.ForegroundColor = (ConsoleColor)13;
            Console.Write(m + "  ");
            if (i == 1)
                x = 10;
                Console.ForegroundColor = (ConsoleColor)x;

        }
        public static void Mthree(int m, int i)
        {
            int x = 10;
            if (i == 1)
                x = 13;
            Console.ForegroundColor = (ConsoleColor)11;
            Console.Write("|   ");
            Console.ForegroundColor = (ConsoleColor)13;
            Console.Write(m + " ");
            if (i == 1)
                x = 10;
                Console.ForegroundColor = (ConsoleColor)x;
        }
       
    }
}
