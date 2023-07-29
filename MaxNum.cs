using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopProj
{
    internal class MaxNum
    {
        static void Main(string[] args)
        {
            // משתנה לספירת כמות הפעמים שהופיע המספר הגדול ביותר
            int count = 0;

            // קלוט של מספר המספרים 
            Console.WriteLine("Enter a number of the numbers: ");
            int n = int.Parse(Console.ReadLine());

            // קלט המספר הראשון
            Console.WriteLine("Enter number 1: ");
            int num = int.Parse(Console.ReadLine());

            int max = num;

            // לולאה למציאת המספר הגדול ביותר ולספירת הפעמים שהוא מופיע
            for (int i = 1; i <= n -1; i++)
            {
                Console.WriteLine($"Enter a number {i + 1}: ");
                num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                    count = 1;
                }

                else if (num == max)
                    count++;
            }

            
            Console.WriteLine($"The largest number is {max} and it appeared {count} times.");
        }
    }
}
