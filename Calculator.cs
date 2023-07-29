using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class Calculator
    {

        // קולט שני מספרים ומחזיר את סכומם
        public static int Add(int a, int b)
        { 
            return a + b;
        }
        
        // קולט שני מספרים ומחזיר את הפרשם
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        // קולט שני מספרים ומחזיר את מכפלתם
        public static int Mult(int a, int b)
        {
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                sum += b;
            }
            return sum;
        }

        // קולט שני מספרים מספרים ומחזיר את החלוקה של הראשון בשני
        public static int Div(int a, int b)
        {
            int count = 0;
            while ( a >= b)
            { 
                a -= b;
                count++; 
            }
            return count;
        }

        // קולט שני מספרים ומחזיר את תוצאת הממשית החילוק של הראשון בשני
        public static double Divide(int a, int b)
        {
            return (double)a / b;
        
        }

        // קולט שני מספרים ומחזיר את השאירית החילוק של הראשון בשני
        public static int Mod(int a, int b)
        {
            while (a >= b)
            {
                a -= b;
            }
            return a;
        }

        // נקלט שני מספרים ומחזיר את תוצאת החזקה של הראשון בשני
        public static int Pow(int a, int b)
        {
            int x = a;
            for (int i = 1; i < b; i++)
            { 
                a = a * x;
            }
            return a;
        }

        // נקלט מספר ומחזיר האם הוא מספר 
        public static Boolean Prime(int a)
        {
            int sqNum = (int)Math.Sqrt(a);
            for(int i = 2; i <= sqNum; i++)
            {
                if(sqNum % i == 0)
                    return false;
            }
            return true;
        
        }

        // נקלט מספר ומחזיר את השורש שלו
        public static double root(double num)
        {
            double b = num;
            double a = 1;
            double eps = 0.01;
            double x;
            while (Math.Abs(a - b) > eps)
            {
                x = (a + b) / 2;
                if (Math.Pow(x, 2) < num)
                {
                    a = x;
                }
                else
                {
                    b = x;

                }
            }
            return a;
        }

        //מקבלת שני מספרים שלים ומחזירה את המחלק הגדול ביותר שלהם
        public static int Mag(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

    }
}
