using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForLoopProj
{
    internal class Temperature
    {
        static void Main(string[] args)
        {
            // משתנה לטמפרטורה הנמוכה ביותר שיכולה להיותר
            const int ABSOBUTE_ZERO = -274;

            // משתנה ליום בו הייתה בטמפרטורה הגבוה ביותר 
            int day = 1;

            // קלט מספר הימים
            Console.WriteLine("Enter the number of days: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // משתנה לטמפרטורה הגבוה ביותר
            int max = ABSOBUTE_ZERO;
            
            // לולאה למציאת הטמפרטורה הגבוה ביותר ובאיזה יום היא
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter the temperature of the during the day {i}: ");
                int temp = int.Parse(Console.ReadLine());
                if (temp > max)
                {
                    max = temp;
                    day = i;
                }
                Console.WriteLine();
            }

            // פלט מה הטמפרטורה הגבוה ביותר ובאיזה יום היא
            Console.WriteLine($"The highest temperature was {max} during the day {day}.");
        }
    }
}
