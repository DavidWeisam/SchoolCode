using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class Chars
    {

        // בודק האם התו הוא מסוג אות גדולה
        // אם לא false מחזיר true אם כן מחזיר

        public static Boolean IsUpper(char ch)
        {
            if (ch >= 'A' && ch <= 'Z')
                return true;
            return false;
        }

        // בודק האם התו הוא מסוג אות קטנה
        // אם לא false מחזיר true אם כן מחזיר
        public static Boolean IsLower(char ch)
        {
            if (ch >= 'a' && ch <= 'z')
                return true;
            return false;
        }

        // בודק האם התו שנקלט הוא מסוג מספר
        // אם לא false מחזיר true אם כן מחזיר
        public static Boolean IsDigit(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return true;
            return false;
        }


        // מקבל קלט של תו מסוג תו קטן
        // מחזיר את אותו תו רק כתו גדול
        public static char ToUpper(char ch)
        {
            int ch1 = ch - 32;
            return ((char)ch1);
        }

        // מקבל קלט של תו מסוג תו גדול
        // מחזיר את אותו תו רק כתו קטן
        public static char ToLower(char ch)
        {
            int ch1 = ch + 32;
            return (char)ch1;
        }

        // מקבל קלט של תו מספרי
        // מחזיר את אותו התו המספרי כמספר
        public static int CharToNum(char ch)
        {
            int ch1 = ch - 48;
            return (ch1);
        }

        // מקבל תו 
        // מחזיר את התו הבא
        public static char NextChar(char ch)
        {
            int ch1 = ch + 1;
            return (char)ch1;
        }

        // מקבל תו
        // מחזיר את התו הקודם
        public static char PrevChar(char ch)
        {
            int ch1 = ch - 1;
            return (char)ch1;
        }

        // מקבל תו 
        // מחזיר את התו הבא
        // בצורה מעגלית
        public static char NextLetter(char ch)
        {
            if ((char)ch == 'Z')
                return 'A';
            else if ((char)ch == 'z')
                return 'a';

            else
            {
                int ch1 = ch + 1;
                return (char)ch1;
            }
        }


        // מקבל תו 
        // מחזיר את התו הקודם
        // בצורה מעגלית
        public static char PrevLetter(char ch)
        {
            if ((char)ch == 'A')
                return 'Z';
            else if ((char)ch == 'a')
                return 'z';

            else
            {
                int ch1 = ch - 1;
                return (char)ch1;
            }
        }




    }
}
