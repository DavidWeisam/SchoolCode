using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Num1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int age;
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Enter your age: ");
                age = int.Parse(Console.ReadLine());
               
                if (age > 22 && age < 40) 
                    sum++;
            
            }
            Console.WriteLine($"The number of the workeres between the ages 44 and 22 is {sum}.");
        }
    }
}
