using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class MyMath
    {
        static void Main(string[] args)
        {
            // משתנה לתחום המספרים
            Console.WriteLine("Type the edge of the number field -->");
            int k = int.Parse(Console.ReadLine());

            // שני המספרים המחושבים
            int a = GetNum(k);
            int b = GetNum(k);

            //מסננת קלוט 
            while (a < b)
            {
                Console.WriteLine("Erro, Please make sure the second number is less than or equal to the first number.");
                b = GetNum(k);
            }
            // פלט של כל פעולת החישבון על שני המספרים
            Console.WriteLine($"{a} + {b} = {Calculator.Add(a, b)} ");
            Console.WriteLine($"{a} - {b} = {Calculator.Sub(a, b)} ");
            Console.WriteLine($"{a} * {b} = {Calculator.Mult(a, b)} ");
            Console.WriteLine($"{a} / {b} = {Calculator.Div(a, b)} ");
            Console.WriteLine($"{a} / {b} = {Calculator.Divide(a, b)} ");
            Console.WriteLine($"{a} % {b} = {Calculator.Mod(a, b)} ");
            Console.WriteLine($"{a} ^ {b} = {Calculator.Pow(a, b)} ");
            Console.WriteLine($"The number {a} is {Calculator.Prime(a)} Prime number.");
            Console.WriteLine($"The number {b} is {Calculator.Prime(b)} Prime number.");
            Console.WriteLine($"The square root of the number {a} is {Calculator.root(a)}");
            Console.WriteLine($"The square root of the number {b} is {Calculator.root(b)}");
            Console.WriteLine($"The biggest mehalk of the two numbers is {Calculator.Mag(a, b)}");
        }

        //שיטה  אשפר מקבלת קלט של תחום המספרים מבקשת קלט של מספר ובודקת אם המספר בתחום
        public static int GetNum(int k)
        {
            Console.WriteLine("Type a positiv number --> ");
            int a = int.Parse(Console.ReadLine());

            while (a <= 0 && a > k)
            {
                Console.WriteLine("Erro, please type a positive numbers.");

                Console.WriteLine("Type a positiv number --> ");
                a = int.Parse(Console.ReadLine());

            }
            return a;
        }

        
    }
}
/*
    Type the edge of the number field -->
    10
    Type a positiv number -->
    7
    Type a positiv number -->
    2
    7 + 2 = 9
    7 - 2 = 5
    7 * 2 = 14
    7 / 2 = 3
    7 / 2 = 3.5
    7 % 2 = 1
    7 ^ 2 = 49
    The number 7 is False Prime number.
    The number 2 is True Prime number.
    The square root of the number 7 is 2.640625
    The square root of the number 2 is 1.4140625
    The biggest mehalk of the two numbers is 1
 */
