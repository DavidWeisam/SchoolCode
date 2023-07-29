using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class Hangman
    {
        static void Main(string[] args)
        {
            String[] words = { "dog", "cat", "teacher", "table", "computer", "moon", "book"};
            Random rnd = new Random();
            int num = rnd.Next(0, 7);
           
            String wrd = words[num];
            

            Char[]  guess = new Char[wrd.Length];
            for (int i = 0; i < wrd.Length; i++)
                guess[i] = '_';


            
            Console.WriteLine("Guess a Char of the word");
            Char ch = Char.Parse(Console.ReadLine());
            int counter = 0;
            while(counter < 6)
            {
                for (int j = 0; j < guess.Length; j++)
                {
                    if (guess[j] == '_');
                        
                }

                if (wrd.IndexOf(ch) == -1)
                {
                    counter++;

                    switch (counter)
                    {
                        case 0:
                            Level0();
                            break;

                        case 1:
                            Level1();
                            break;

                        case 2:
                            Level2();
                            break;

                        case 3:
                            Level3();
                            break;

                        case 4:
                            Level4();
                            break;

                        case 5:
                            Level5();
                            break;

                        case 6:
                            Level6();
                            break;
                    }

                }
                else
                {

                    for (int k = 0; k < guess.Length; k++)
                    {
                        if (wrd[k] == ch)
                            guess[k] = ch;
                    }
                }
               
                
            
            }
        }


        public static void Level6()
        {
            Console.WriteLine(" ____  ");
            Console.WriteLine(" |  | ");
            Console.WriteLine(" |  0 ");
            Console.WriteLine(" | /|\\ ");
            Console.WriteLine(" | / \\");
            Console.WriteLine(" -----");


        }

        public static void Level5()
        {
            Console.WriteLine(" ____  ");
            Console.WriteLine(" |  |  ");
            Console.WriteLine(" |  0  ");
            Console.WriteLine(" | /|\\");
            Console.WriteLine(" | /   ");
            Console.WriteLine(" ----- ");


        }

        public static void Level4()
        {
            Console.WriteLine(" ____  ");
            Console.WriteLine(" |  |  ");
            Console.WriteLine(" |  0  ");
            Console.WriteLine(" | /|\\");
            Console.WriteLine(" |     ");
            Console.WriteLine(" ----- ");


        }

        public static void Level3()
        {
            Console.WriteLine(" ____  ");
            Console.WriteLine(" |  |  ");
            Console.WriteLine(" |  0  ");
            Console.WriteLine(" | /|  ");
            Console.WriteLine(" |     ");
            Console.WriteLine(" ----- ");


        }

        public static void Level2()
        {
            Console.WriteLine(" ____  ");
            Console.WriteLine(" |  |  ");
            Console.WriteLine(" |  0  ");
            Console.WriteLine(" |  |  ");
            Console.WriteLine(" |     ");
            Console.WriteLine(" ----- ");


        }

        public static void Level1()
        {
            Console.WriteLine(" ____  ");
            Console.WriteLine(" |  |  ");
            Console.WriteLine(" |  0  ");
            Console.WriteLine(" |    ");
            Console.WriteLine(" |     ");
            Console.WriteLine(" ----- ");


        }

        public static void Level0()
        {
            Console.WriteLine(" ____  ");
            Console.WriteLine(" |  |  ");
            Console.WriteLine(" |     ");
            Console.WriteLine(" |     ");
            Console.WriteLine(" |     ");
            Console.WriteLine(" ----- ");


        }
    }


    
}
