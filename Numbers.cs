using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class Numbers
    {
        
        static void Main(string[] args)
        {
            // משתנים לכמות הזוגיים, לכמות עם ה5 
            int countEven = 0;
            int count5Digits = 0;

            // משתנים למספר הנקלט, סכום ספרותיו וכמות ספרותיו
            int num, sumD, numD;
         

            String x = "";
            for (int i = 1; i <= 10; i++)
            {
                // קליטת הערכים מהפונקציות
                num = GetNum();
                sumD = SumOfDigit(num);
                numD = NumOfDigits(num);

                // בדיקת זוגי או לא
                if (num % 2 == 0)
                    countEven++;

                // 5 מספרים או לא
                if (numD == 5)
                    count5Digits++;

                // משבתנים לרווים בין הפלטים
                String space1 = "";
                String space2 = "";

                // חישוב הרווחים
                for (int j = 0; j < 15 - numD; j++)
                {
                    space1 += " ";
                }
                for (int j = 0; j < 23 - NumOfDigits(sumD); j++)
                {
                    space2 += " ";
                }

                // שורת הפלט של מספר יחדי
                x += $"\n{num}{space1}{sumD}{space2}{numD}";
            }
            // הפלט הסופי
            Console.WriteLine("The number:    The sum of digits:    The num of digits:");
            Console.Write(x);
            Console.WriteLine("\n\n");
            Console.WriteLine($"The number of even number is: {countEven}");
            Console.WriteLine($"The number of numbers with 5 digits is: {count5Digits}");
        }

  
        // פעולה קןלטת ומחזירה מספר שלם  
        public static int GetNum()
        {
            Console.WriteLine("Type a positive number --> ");
            int num = int.Parse(Console.ReadLine());
            while (num < 0 || num > 999999999)
            {
                Console.WriteLine("Error! not a positive number/ try again");
                Console.WriteLine("Type a positive number --> ");
            }
            return num;
        }


        // הפעולה מקבת מספר שלם וחיובי
        // ומחזירה את סכום ספרותיו
        public static int SumOfDigit(int num)
        {
            int sum = 0;  // סוכם הספרות

            while (num != 0)
            {
                sum += num % 10; // הוספת לסכום את ספרת האחדות 
                num = num / 10;  // מסלק מהמספר את ספרת האחדות
            }
            return sum; 
        }

        // פעולה המקבלת מספר שלם וחיובי
        // ומחזירה את כמות הספרות שיש במספר
        public static int NumOfDigits(int num)
        {
            int num_of_digits = 0;  // מספר הספרות

            while (num != 0)
            {
                num_of_digits ++; // הוספת לצובר את ספרת האחדות 
                num = num / 10;  // מסלק מהמספר את ספרת האחדות
            }
            return num_of_digits;
        }


        /*
         Type a positive number -->
        1234
        Type a positive number -->
        234
        Type a positive number -->
        5467
        Type a positive number -->
        65844
        Type a positive number -->
        4444
        Type a positive number -->
        66666
        Type a positive number -->
        87567
        Type a positive number -->
        123345
        Type a positive number -->
        444
        Type a positive number -->
        4
        The number:    The sum of digits:    The num of digits:

        1234           10                     4
        234            9                      3
        5467           22                     4
        65844          27                     5
        4444           16                     4
        66666          30                     5
        87567          33                     5
        123345         18                     6
        444            12                     3
        4              4                      1
         */
    }
}
