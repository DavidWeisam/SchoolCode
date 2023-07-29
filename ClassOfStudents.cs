using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
     class ClassOfStudents
     {
        public static void Main(string[] args)
        {
            Sturdent str1 = new Sturdent("Yossi", 70, 80, 64);
            Sturdent str2 = new Sturdent("Yaffa", 79, 0, 100);

            Console.WriteLine(str1.ToString());
            Console.WriteLine(str2.ToString());

            str2.SetGrade2(91);
            Console.WriteLine(str2.ToString());

            double avg1 = str1.GetGrade1() + str1.GetGrade2() + str1.GetGrade3();
            double avg2 = str2.GetGrade1() + str2.GetGrade2() + str2.GetGrade3();

            if (avg1 > avg2)
                Console.WriteLine(str1.GetName() + " is better!");
            else if (avg2 > avg1)
                Console.WriteLine(str2.GetName() + " is better!");
            else
                Console.WriteLine(str1.GetName() + " and " + str2.GetName() + " are same."); 
        }
    }
}
