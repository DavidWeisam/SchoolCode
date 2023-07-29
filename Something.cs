using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Something
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 7;
            int num = 12;
            for (int i = 0; i <= 6; i++)
            {
                for (int t = 0; t <= y; t++)
                {
                    Console.WriteLine(num);
                    num++;
                }

                num = num + x;
                x ++;
                y --;
             
            }

            Console.WriteLine(89);


        }
    }
}
