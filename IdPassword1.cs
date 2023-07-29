using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class IdPassword1
    {
        static void Main(string[] args)
        {
            // Input of the id.
            Console.WriteLine("Enter your id: ");
            int id = int.Parse(Console.ReadLine());
            
            // Output the answer if the id is corrct or not.
            if(ChkId(id))
                Console.WriteLine($"The id: {id}, is correct.");
            else
                Console.WriteLine($"The id: {id}, is incorrect.");
        }

        // Input number of the id
        // Output true or false if the id is correct of not.
        public static Boolean ChkId(int num)
        {
  
            // Variable of the counter.
            int counter = 0;

            // Variable of the review number of the id.
            int reviewNum = num % 10;
            num /= 10;
            
            // Arry of the numbers of the id.
            int[] id = new int[8];

            // loop that checks if the id is correct.
            for (int i = 0; i < id.Length; i++)
            {
                
                id[i] = num % 10;
                num /= 10;

               
                if (i % 2 != 0)
                    id[i] = id[i] * 2;

                
                if (id[i] > 9)
                    counter += Sum(id[i]);
                else
                    counter += id[i];
            }

            return (reviewNum == 10 - counter % 10);
        }

        // Input two digit number.
        // Output the sum of both numbers.
        public static int Sum(int num)
        {
            return(num % 10 + num / 10);
        }
    }
}
/*
    Enter your id:
    330597055
    The id: 330597055, is correct.
 
    Enter your id:
    330517055
    The id: 330517055, is incorrect.
 
 */
