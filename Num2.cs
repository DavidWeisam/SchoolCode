using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Num2
    {
        static void Main(string[] args)
        {
            int good_grade = 0;
            int grade;
            int counter1 = 0;
            double counter2 = 0;
            double average;
            for (int i = 1; i <= 10; i++)
            { 
                Console.Write("enter your grade: ");
                grade = int.Parse(Console.ReadLine());

                if (grade > 90 && grade < 100)
                    good_grade++;
               
                if (grade > 60 && grade < 100)
                {
                    counter1++;
                    counter2 += grade;
                }
            }
            average = counter2 / counter1;
            Console.WriteLine($"The number of the studens with grade over 90: {good_grade}");
            Console.WriteLine($"The averge of the grades over 60 is: {average}");

        }
    }
}
