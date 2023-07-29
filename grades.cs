using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class grades
    {
        static void Main(string[] args)
        {
            // קלט כמות התלמידים
            Console.Write("Type the number of the studens --> ");
            int n = int.Parse(Console.ReadLine());

            // הכנסת הציונים של התלמידים למערך
            int[] grades = new int[n];
            ArrFill(grades);
            Console.WriteLine();

            // פלט של הציונים שנקלטו
            Console.WriteLine("The grades of the studens are:");
            ArrShow(grades);
            Console.WriteLine();

            // פלט של ממוצא הציונים
            double average = ArrAvg(grades);
            Console.Write($"The average of the grades is --> {average}");
            Console.WriteLine();

            // פלט של הציונים הגבוהים מהממוצע
            Console.WriteLine("The grades thet bigger then the average is: ");
            int moreThenAvg = GreaterThenAverage(grades, average);
            Console.WriteLine();

            // פלט של הציונים הגבוהים מהממוצע
            Console.WriteLine($"The number of the grades that bigger then the average is: {moreThenAvg}");
        }


        // פעולה אשר מקבלט מערך ריק ומכניסה אליו מספרים שלמים
        public static void ArrFill(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Type the grade of student {i + 1} --> ");
                int grade = int.Parse(Console.ReadLine());
                grades[i] = grade;
            }

        }

        // פעולה אשר מקבלת מערך של מספקים ומחזירה את ממוצע המפספרים
        public static double ArrAvg(int[] grades)
        {
            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }

            double average = sum / grades.Length;
            return average; 
        }

        // פעולה אשר מקבלת מערך עם מספרים ומדפיסה את המספרים בשורה
        public static void ArrShow(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write(grades[i] + " ");
            }
        }

        // פעולה אשר מקבל מערך של מספרים וממוצע המספרים, הפעולה תחזיר את כמות המספרים שגדולים ממש מהממוצע את תדפיס אותם
        public static int GreaterThenAverage(int[] grades, double avg)
        {
            int counter = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > avg)
                {
                    counter++;
                    Console.Write(grades[i] + " ");
                }
            }
            return counter;
        }
    }
}

    /*
    Type the number of the studens --> 3
    Type the grade of student 1 --> 100
    Type the grade of student 2 --> 70
    Type the grade of student 3 --> 80

    The grades of the studens are:
    100 70 80

    The average of the grades is --> 83

    The grades thet bigger then the average is:
    100

    The number of the grades that bigger then the average is: 1 
 
 
 
*/
