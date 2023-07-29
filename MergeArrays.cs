using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class MergeArrays
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            ArryArrangement.FillArry(a, 0, 10);
            ArryArrangement.FillArry(b, 0, 10);

            ArryArrangement.ArrySortBubble(a);
            ArryArrangement.ArrySortBubble(b);

            int[] c = new int[a.Length + b.Length];

            ArryArrangement.ShowArry(MergeNoDup(a,b,c));
            ArryArrangement.ShowArry(MergeDup(a, b, c));
            ArryArrangement.ShowArry(Dup(a, b, c));



        }

        public static int[] MergeNoDup(int[] a, int[] b, int[] c)
        {
            

            int i = 0;
            int j = 0;
            int k = 0;

            while (j < b.Length && i < a.Length)
            {
                if (a[i] < b[j])
                {
                    c[k] = a[i];
                    i++;
                }

                else
                {
                    c[k] = b[j];

                    if (b[j] == a[i])
                    {
                        i++;
                    }
                    j++;
                }
                k++;
            }

            while (i < a.Length)
            {
                c[k] = a[i];
                i++;
                k++;

            }
            while (j < b.Length)
            {
                c[k] = b[j];
                j++;
                k++;

            }
            return c;
        }

        public static int[] MergeDup(int[] a, int[] b, int[] c)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (j < b.Length && i < a.Length)
            {
                if (a[i] < b[j])
                {
                    c[k] = a[i];
                    i++;
                }

                else
                {
                    c[k] = b[j];
                    j++;
                }
                k++;
            }

            while (i < a.Length)
            {
                c[k] = a[i];
                i++;
                k++;

            }
            while (j < b.Length)
            {
                c[k] = b[j];
                j++;
                k++;

            }
            return c;
        }

        public static int[] Dup(int[] a, int[] b, int[] c)
        {
            
            int i = 0;
            int j = 0;
            int k = 0;

            while (j < b.Length && i < a.Length)
            {
               
                if(b[j] == a[i])
                {
                    c[k] = b[j];
                    i++;
                    j++;
                    k++;
                }
                
            }
            return c;
        }

    }
}
