using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IfSwitchProject
{
    internal class SnakeLetters
    {
        static void Main(string[] args)
        {
            // The two players of the game.
            int player1 = 0;
            int player2 = 1;
            int num;

            // The opening of the game.
            Console.ForegroundColor = (ConsoleColor)14;
            Console.WriteLine("Welcom to Snake and ketters game");
            Console.ForegroundColor = (ConsoleColor)1;
            Console.WriteLine("- The blue numbers are the letters.");
            Console.ForegroundColor = (ConsoleColor)4;
            Console.WriteLine("- The red numbers are the snakes.");
            Console.ForegroundColor = (ConsoleColor)2;
            Console.WriteLine("-The players colors are green.");
            Console.ForegroundColor = (ConsoleColor)14;
            Console.WriteLine("To start the game press Enter:");

            // To start the game you need to press Enter.
            char ch = (char)Console.Read();
            while (ch != '\r')
            {
                Console.WriteLine("To start the game press Enter:");
                ch = (char)Console.Read();
            }
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

            // The loop that give to both players to play,
            // until ome of them get to 25 (win the game)
            while (player1 != 25 && player2 != 25)
            {
                // The turn of the first player.
                num = Dice();
                Console.WriteLine(num);
                player1 += num;
                player1 = Snakeletters(player1);
                Board(player1, player2);
                if (player1 != 25)
                {
                    Console.WriteLine("THe next player torn, press Enter:");
                    ch = (char)Console.Read();
                    while (ch != '\r')
                    {
                    
                        ch = (char)Console.Read();
                    }
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
               
                    // The turn of teh second player.
                    num = Dice();
                    Console.WriteLine(num);
                    player2 += num;
                    player2 = Snakeletters(player2);
                    Board(player1, player2);

                    Console.WriteLine("THe next player torn, press Enter:");
                    ch = (char)Console.Read();
                    while (ch != '\r')
                    {

                        ch = (char)Console.Read();
                    }
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                }
            }
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

            // The announcement of the winner of the game.
            // Or the first player or the second player.
            if (player1 == 25)
                Console.WriteLine("The winer is Player1");
            else
                Console.WriteLine("The winer is Player2");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

        }


        // Function of the Dice of  the game.
        public static int Dice()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }

 
        // Function of the snake and the letters of the game.
        public static int Snakeletters(int num)
        {
            if (num < 26)
            {
                switch (num)
                {
                    case 9:
                        return 2;
                        break;
                    case 21:
                        return 11;
                        break;
                    case 18:
                        return 23;
                        break;
                    case 5:
                        return 16;
                        break;

                    default:
                        return num;
                }
            }
            else
                return 25;
        }


        // funcion of the board of the game.
        public static void Board(int p1, int p2)
        {
            Console.ForegroundColor = (ConsoleColor)14;
            Kave();
            int num = 21;
            int x = 0;
            
            for (int i = 0; i < 5; i++)
            {
                
                for (int k = 0; k < 5; k++)
                {

                    if (i % 2 != 0)
                        k = k * -1;
                    x = num + k;
                    
                    if (x > 9)
                    {
                        
                        Console.Write("| ");
                        if(x == 21 || x == 20 || x == 11)
                            Console.ForegroundColor = (ConsoleColor)4;
                        if(x == 15 || x == 16 || x == 18 || x == 23)
                            Console.ForegroundColor = (ConsoleColor)1;
                        if (x == p1)
                        {
                            Console.ForegroundColor = (ConsoleColor)2;
                            Console.Write("P1");
                        }
                        else if (x == p2)
                        {
                            Console.ForegroundColor = (ConsoleColor)2;
                            Console.Write("P2");
                        }
                        else
                            Console.Write(x);
                        Console.ForegroundColor = (ConsoleColor)14;
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("|");
                        if (x == 9 || x == 2)
                            Console.ForegroundColor = (ConsoleColor)4;
                        if (x == 5 || x == 6)
                            Console.ForegroundColor = (ConsoleColor)1;
                        if (x == p1)
                        {
                            Console.ForegroundColor = (ConsoleColor)2;
                            Console.Write(" " + "P1" + " ");
                        }
                        else if (x == p2)
                        {
                            Console.ForegroundColor = (ConsoleColor)2;
                            Console.Write(" " + "P2" + " ");
                        }
                        else
                            Console.Write("  " + (x) + " ");
                        Console.ForegroundColor = (ConsoleColor)14;
                    }
                    if (i % 2 != 0)
                        k = k * -1;


                }
                if(i % 2 == 0)
                    num -= 1;
                else
                    num -= 9;

                Console.WriteLine("|");
                Kave();
                
            }
        }

        public static void Kave()
        {
            String kav = "+";
            for (int i = 0; i < 5; i++)
            {
                kav += "----+";
            }
            Console.WriteLine(kav);
        }
    }
}   