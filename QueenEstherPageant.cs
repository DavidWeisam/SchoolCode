using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class QueenEstherPageant
    {

        static int max;
        static int secMax;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of contest participants: ");
            int n = int.Parse(Console.ReadLine());
            int[] arry = new int[n];
            ArrayInitialization(arry);

        }

        public static void ArrayInitialization(int[] arry)
        {
            for (int i = 0; i < arry.Length; i++)
            { 
                arry[i] = 0;
            }
        }

        public static void ShowArray(int[] arry)
        {
            for (int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i] + ", ");
            }
        }

        public static void GetVote(int[] arry)
        {
            Console.WriteLine("Enter your vote (Enter 999 to exit) -->");
            int k = int.Parse(Console.ReadLine());
            while(k != 999 && k <= arry.Length && k > 0)
            {
                arry[k - 1]++;
                Console.WriteLine("Enter your vote (Enter 999 to exit) -->");
                k = int.Parse(Console.ReadLine());
            }
        }


        public static void MaxAndSec(int[] arry)
        { 
            
        
        
        
        }


    }
}
