using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class MagicNumbers
    {
        static void Main(string[] args)

            // שם המגיש: דוד וייצמן

        {
            int num;                                                // מספר שניקלט כקלט
            int d1;                                                 // משתנה לספרת האחדות
            int d10;                                                // משתנה לספרת העשרות
            int d100;                                               // משתנה לספרת המאות
            int d1000;                                              // משתנה לספרת האלפים
            int newNum;                                             // משתנה למספר ההפוך מזה שניקלט

            Console.Write("type a 2 digits number: ");              //קליטה של מספר עם 2 ספרות
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            d10 = num / 10;                                         //חישוב
            d1 = num % 10;

            newNum = d1 * 10 + d10;                                 //פלט של שני הספרות בסדר הפוך
            Console.WriteLine("new num = " + newNum);
            Console.WriteLine("\n" +
                "");

            Console.Write("type a 3 digits number: ");          //קליטה של מספר עם 3 ספרות
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            d1 = (num % 100) % 10;                                  //חישוב
            d10 = (num % 100) / 10;
            d100 = num / 100;

            newNum = d1 * 100 + d10 * 10 + d100;                    //פלט של שלושת הספרות בסדר הפוך
            Console.WriteLine(" new num is: " + newNum);
            Console.WriteLine("\n");

            
            Console.Write("type a 4 digits number: ");         //קליטה של מספר עם 4 ספרות
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            d1 = ((num % 1000) % 100) % 10;                        //חישוב
            d10 = ((num % 1000) % 100) / 10;
            d100 = (num % 1000) / 100;
            d1000 = num / 1000;

            newNum = d1 * 1000 + d10 * 100 + d100 * 10 + d1000;    //פלט של ארבעת הספרות בסדר הפוך
            Console.WriteLine(" new num is: " + newNum);

        }
    }
}

/*
 type a 2 digits number: 12


new num = 21


type a 3 digits number: 123


 new num is: 321


type a 4 digits number: 1234


 new num is: 4321
 */