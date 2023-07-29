using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Birthday
    {
        static void Main(string[] args)
        {
            // צובר מספר הילדים שיש להם יום הולדת בחודש
            int counter = 0;

            // קלט של החודש ומספר הילדים
            Console.Write("Enter the number of the month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the children: ");
            int numChildren = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // לולאה שקולט עבור כל ילד את שמו ותאריכו ובודקת האם יש לו יום הולדת בחודש הנקלט
            for (int i = 0; i < numChildren; i++)
            {
                Console.Write("Enter the name of the children: ");
                string name = Console.ReadLine();

                Console.Write("Enter the date of the children: ");
                int date = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (date % 100 == month)
                {
                    Console.WriteLine($"{name} have good day!"); // פשט של ברכה לכל ילד שיש לו יום הולדת בחודש הנקלט
                    Console.WriteLine();
                    counter++;
                }
            }

            // פךט של כמות הילדים שיש להם יום הולדת בחודש הנקלט
            Console.WriteLine($"{counter} children have a birthday in {month}");
        }
    }
}
/*
Enter the number of the month: 11
Enter the number of the children: 5

Enter the name of the children: dudu
Enter the date of the children: 2011

dudu have good day!

Enter the name of the children: roy
Enter the date of the children: 301

Enter the name of the children: noam
Enter the date of the children: 2211

noam have good day!

Enter the name of the children: bobo
Enter the date of the children: 307

Enter the name of the children: tony
Enter the date of the children: 1212

2 children have a birthday in 11
 
 
 
 
 
 
 
 
 */
