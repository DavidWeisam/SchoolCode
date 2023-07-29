using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Date
    {
        static void Main(string[] args)
        {
            // קליטת קלט של היום חודש ושנה
            Console.WriteLine("Enter the number of the day: ");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of the mooth: ");
            int moth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of the year: ");
            int year = int.Parse(Console.ReadLine());

            //משתנה עזר לבדיקה האם החודשים והימים הגיונים
            bool counter = true;

            // בדיקת האם הימים והחודשים הגיוניים
            if (moth < 0 || moth > 12)
            {
                Console.WriteLine("Erro moth.");
                counter = false;
            }
            if (day < 0 || day > 31)
            {
                Console.WriteLine("Erro day.");
                counter = false;

            }

            if (counter)
            {
                // משתנה לשנה המאובר
                bool leepYear = false;

                // בדיקה האם יש שנה מאוברת
                if (year % 400 == 0)
                    leepYear = true;
                else
                {
                    if (year % 4 == 0 && year % 100 != 0)
                        leepYear = true;
                }


                switch (moth)
                {
                    // פלט כאשר יש שנה מאוברת
                    case 2:
                        {
                            if (leepYear == true)
                            {
                                if (day > 29)
                                    Console.WriteLine("day not valid.");
                                else
                                {
                                    Console.WriteLine(day + "/" + moth + "/" + year);
                                    Console.WriteLine("day: " + day + ", moth: February, year: " + year);
                                }
                            }
                             break;
                        }
                    
                    // פלט של החודשים בעלי 30 ימים
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        {
                            if (day >= 31)
                                Console.WriteLine("day not valid.");
                            else
                            {
                                Console.WriteLine(day + "/" + moth + "/" + year);
                                if (moth == 4)
                                    Console.WriteLine("day: " + day + ", moth: April, year: " + year);

                                if (moth == 6)
                                    Console.WriteLine("day: " + day + ", moth: June, year: " + year);

                                if (moth == 9)
                                    Console.WriteLine("day: " + day + ", moth: September, year: " + year);

                                if (moth == 11)
                                    Console.WriteLine("day: " + day + ", moth: November, year: " + year);
                            }
                            break;
                        }

                    // פלט של החודשים בעלי 31 ימים
                    default:
                        {
                            if (day > 31)
                                Console.WriteLine("day not valid.");
                            else
                            {
                                Console.WriteLine(day + "/" + moth + "/" + year);
                                if (moth == 1)
                                    Console.WriteLine("day: " + day + ", moth: January, year: " + year);

                                if (moth == 3)
                                    Console.WriteLine("day: " + day + ", moth: March, year: " + year);

                                if (moth == 5)
                                    Console.WriteLine("day: " + day + ", moth: May, year: " + year);

                                if (moth == 7)
                                    Console.WriteLine("day: " + day + ", moth: July, year: " + year);
                                
                                if (moth == 8)
                                    Console.WriteLine("day: " + day + ", moth: August, year: " + year);

                                if (moth == 10)
                                    Console.WriteLine("day: " + day + ", moth: October, year: " + year);

                                if (moth == 12)
                                    Console.WriteLine("day: " + day + ", moth: December, year: " + year);
                            }
                            break;
                        }


                }

            }
            
        }
    }

    /*
        --------------------------------
        Enter the number of the day:
        30
        Enter the number of the mooth:
        2
        Enter the number of the year:
        2020
        day not valid.     
        --------------------------------
        Enter the number of the day:
        31
        Enter the number of the mooth:
        9
        Enter the number of the year:
        2022
        day not valid.
        --------------------------------
        Enter the number of the day:
        6
        Enter the number of the mooth:
        9
        Enter the number of the year:
        2000
        6/9/2000
        day: 6, moth: September, year: 2000
        --------------------------------
     */


}
