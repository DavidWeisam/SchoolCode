using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class Fbonachi
    {
        // פעולה אשר מתפיסה את ה10 המספרים הראשונים בסדרת פיבונצ'י
        public static void Fibonacci()
        {
            int a = 0;
            int b = 1;
            
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                a += b;
                b += a;
            }
        }

        // פעולה אשר מקבלט קלט של מספר ומתפיסה את כל המספרים הקטנים בסדרת הפיבונצ'י מהמספר שניקלט
        // פעולה גם מתפיסה את כמות האיברים בסדרה אשר קטנים מהמספר הנקלט
        public static void Fibonacci(int num)
        {
            int a = 0;
            int b = 1;
            int counter = 0;
            while (num > a)
            {
                Console.WriteLine(a);
                if (num > b)
                {
                    Console.WriteLine(b);
                    counter ++;
                }
                a += b;
                b += a;
                counter++;

            }
            Console. WriteLine($"There is {counter} number that smaller than {num}.");
        }
    }




    /*
        ~~~~~פעולה ראשונה ~~~~~
        0
        1
        1
        2
        3
        5
        8
        13
        21
  

        ~~~~~פעולה שניה ~~~~~
        0
        1
        1
        2
        3
        5
        8
        13
        21
        34
        55
        There is 11 number that smaller than 60.
     */
}