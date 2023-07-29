using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class UesChars
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Third();
        }



        public static void First()
        {
            // קלט של תו
            Console.Write("Enter a string --> ");
            char ch = (char)Console.Read();
            
            
            String str = "";
            // לולאה אשאר פועלת עד לאנתר ומפענחת הצפנה של תו עוקב
            while (ch != '\r')
            {
                str += Chars.PrevLetter(ch);
                ch = (char)Console.Read();
            }

            // פלט של התווים 
            Console.WriteLine(str);
            Console.WriteLine("\n\n\n");
        }


       

        public static void Second()
        {
            // קלט של מרחק ההצפנה
            Console.Write("Enter the length");
            int n = int.Parse(Console.ReadLine());
            
            // קלט של תו מוצפן
            Console.Write("Enter a string --> ");
            char ch = (char)Console.Read();


            String str = "";
            // לןלאה שפועלת עד אנתר אשר מפענחת את הצופק הזזה לפי המרחק שנקלט
            while (ch != '\r')
            {
                if (ch - n < 97)
                {
                    int ch1 = ch - n + 26;
                    str += (char)ch1;
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        ch = Chars.PrevLetter(ch);
                    }
                    str = str + ch;
                }
                ch = (char)Console.Read();
            }
            // פלט
            Console.WriteLine(str);
            Console.WriteLine("\n\n\n");
        }

        public static void Third()
        {
            // קלט של מספרים\ אותיות גדולות\ אותיות קטנות
            Console.Write("Enter a string --> ");
            char ch = (char)Console.Read();


            String str = "";
            while (ch != '\r')
            {
                // מקטין אותיות גדולות
                if (ch >= 65 && ch <= 90)
                {
                    ch = Chars.ToLower(ch);
                    str = str + ch;
                }

                // מגדיל אותיות קטנות
                else if (ch >= 97 && ch <= 122)
                {
                    ch = Chars.ToUpper(ch);
                    str = str + ch;
                }

                // מחזיר את התו המספרי מספר הפעמים של התו המספרי
                else if (ch >= 48 && ch <= 57)
                {
                    int ch1 = Chars.CharToNum(ch);
                    for (int i = 0; i < ch1; i++)
                    {
                        str = str + ch1;
                    }
                }

                else
                {
                    str = str + ch;
                }

                ch = (char)Console.Read();
            }
            // פלט
            Console.WriteLine(str);
            Console.WriteLine("\n\n\n");
        }

    }
}
