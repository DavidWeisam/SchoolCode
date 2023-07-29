using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class NumericalVerbalGrade
    {
        static void Main(string[] args)
        {
            // קליטת קלט של ציון
            Console.Write("Please enter a grade: ");
            int grade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            // משתנה עזר לבדיקת הציון
            int grd = (grade + 5) / 10;

            // בדעקה אם הציון הגיונית
            if (grade > 100 || grade < 0)
                Console.WriteLine("erro");

            // פלט של הערכה מילולית של הציון הנקלט לפי הציון עצמו
            else
            {
                switch (grd)
                {
                    case 10:
                        Console.WriteLine("Exelent");
                        break;
                    case 9:
                        Console.WriteLine("very good");
                        break;
                    case 8:
                        Console.WriteLine("good");
                        break;
                    case 7:
                        Console.WriteLine("almost");
                        break;
                    case 6:
                        Console.WriteLine("enough");
                        break;

                    default:
                        Console.WriteLine("fail");
                        break;
                }
            }
            



        }
 
    }

    /*
    --------------------------
    Please enter a grade: 100

    Exelent
    --------------------------
    Please enter a grade: 78

    good
    --------------------------
    Please enter a grade: 73

    almost
    --------------------------
    Please enter a grade: 40

    fail
    */




}
