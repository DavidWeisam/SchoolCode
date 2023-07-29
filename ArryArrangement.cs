using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class ArryArrangement
    {
        static void Main(string[] args)
        {
            int[] arry1 = new int[7];
            FillArry(arry1, 10, 20);

            int[] arry2 = new int[10];
            FillArry(arry2, 1, 15);

            ShowArry(arry1);
            ShowArry(arry2);

        }

        public static void FillArry(int[] arry, int x, int y)
        {
            Random rnd = new Random();
            for (int i = 0; i < arry.Length; i++)
            {
                arry[i] = rnd.Next(x, y + 1);
            }
        }

        public static void ShowArry(int[] arry)
        {
            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write(arry[i] + ", ");
            }
            Console.WriteLine();
        }


        public static void ArrySortBubble(int[] arry)
        {
            Boolean sorted = false;
            int i = arry.Length - 1;
            while (i > 0 && !sorted)
            {
                sorted = true;
                for (int j = 0; j < i; i++)
                {
                    if (arry[j] > arry[i + 1])
                    {
                        Swap(arry, j, j + 1);
                        sorted = false;
                    }
                }
                i--;
            }
        }




        public static int MaxNumArry(int[] arry)
        {
            int max = arry[0];
            for (int i = 1; i < arry.Length; i++)
            {
                if (arry[i] > max)
                    max = arry[i];
            
            }
            return max;
        }


        public static void ArrySort(int[] arry)
        {
            
        
        
        }




        public static void Swap(int[] arry, int x, int y)
        {
            int temp = arry[x];
            arry[x] = arry[y];
            arry[y] = temp;
        }



    }
}
