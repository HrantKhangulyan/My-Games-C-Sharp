using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_X_And_O_Game
{
    class Game
    {
        static Map map = new Map();
        static Random rnd = new Random();

        public static int RandStart()
        {
            int a = rnd.Next(0, 2);
            return a;
        }

        public static bool IfPlayer1Wins()
        {
            int win = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(map.map[i,j] == "X")
                    {
                        win++;
                    }
                }
                if(win == 3)
                {
                    return true;
                }
                win = 0;
            }

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (map.map[i, j] == "X")
                    {
                        win++;
                    }
                }
                if (win == 3)
                {
                    return true;
                }
                win = 0;
            }


            if( ( map.map[0,0] == "X" && map.map[1, 1] == "X" && map.map[2, 2] == "X") || (map.map[0, 2] == "X" && map.map[1, 1] == "X" && map.map[2, 0] == "X"))
            {
                return true;
            }

            return false;

        }
        public static bool IfPlayer2Wins()
        {
            int win = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (map.map[i, j] == "O")
                    {
                        win++;
                    }
                }
                if (win == 3)
                {
                    return true;
                }
                win = 0;
            }

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (map.map[i, j] == "O")
                    {
                        win++;
                    }
                }
                if (win == 3)
                {
                    return true;
                }
                win = 0;
            }


            if ((map.map[0, 0] == "O" && map.map[1, 1] == "O" && map.map[2, 2] == "O") || (map.map[0, 2] == "O" && map.map[1, 1] == "O" && map.map[2, 0] == "O"))
            {
                return true;
            }

            return false;

        }
        public static bool Draw(int x)
        {
            return (IfPlayer1Wins() == false && IfPlayer2Wins() == false && x == 9);
        }

        public static void TheGame()
        {
            int moves = 0;
            int rand = RandStart();
            map.CreateMap();
            Console.Write("Enter Your name Player 1 : ");
            string name1 = Console.ReadLine();
            Console.Write("Enter Your name Player 2 : ");
            string name2 = Console.ReadLine();
            Player player1 = new Player(name1);
            Player player2 = new Player(name2);
            Console.Clear();

            if(rand == 0)
            {
                Console.WriteLine($"{name1} starts the game !\nPress Enter to continue !");
            }
            else
            {
                Player tmp = new Player("tmp");
                tmp = player1;
                player1 = player2;
                player2 = tmp;
                Console.WriteLine($"{name2} starts the game !\nPress Enter to continue !");
            }
            Console.ReadLine();

            while (true)
            {
                Console.Clear();
                map.ViewMap();
                if (moves % 2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"\n{player1.Name} , Your turn (you put X)\nEnter number from 1 to 9");
                    A:  string b1 = player1.InsertPlayer();                    
                    switch (b1)
                    {
                        case ("1"):
                            {
                               if (map.map[0, 0] == "X" || map.map[0, 0] == "O")
                               {
                                    if (b1 == "1")
                                    {
                                        Console.WriteLine($"{player1.Name} , The place is already taken ! , enter correct value");
                                        goto A;
                                    }
                               }
                               else
                               {                                   
                                  map.map[0, 0] = "X";                                
                               }
                               break;
                            }
                        case ("2"):
                            {
                                if (map.map[0, 1] == "X" || map.map[0, 1] == "O")
                                {
                                    if (b1 == "2")
                                    {
                                        Console.WriteLine($"{player1.Name} , The place is already taken ! , enter correct value");
                                        goto A;
                                    }
                                }
                                else
                                {
                                    map.map[0, 1] = "X";
                                }
                                break;
                            }
                        case ("3"):
                            {
                                if (map.map[0, 2] == "X" || map.map[0, 2] == "O")
                                {
                                    if (b1 == "3")
                                    {
                                        Console.WriteLine($"{player1.Name} , The place is already taken ! , enter correct value");
                                        goto A;
                                    }
                                }
                                else
                                {
                                    map.map[0, 2] = "X";
                                }
                                break;
                            }
                        case ("4"):
                            {
                                if (map.map[1, 0] == "X" || map.map[1, 0] == "O")
                                {
                                    if (b1 == "4")
                                    {
                                        Console.WriteLine($"{player1.Name} , The place is already taken ! , enter correct value");
                                        goto A;
                                    }
                                }
                                else
                                {
                                    map.map[1, 0] = "X";
                                }
                                break;
                            }
                        case ("5"):
                            {
                                if (map.map[1, 1] == "X" || map.map[1, 1] == "O")
                                {
                                    if (b1 == "5")
                                    {
                                        Console.WriteLine($"{player1.Name} , The place is already taken ! , enter correct value");
                                        goto A;
                                    }
                                }
                                else
                                {
                                    map.map[1, 1] = "X";
                                }
                                break;
                            }
                        case ("6"):
                            {
                                if (map.map[1, 2] == "X" || map.map[1, 2] == "O")
                                {
                                    if (b1 == "6")
                                    {
                                        Console.WriteLine($"{player1.Name} , The place is already taken ! , enter correct value");
                                        goto A;
                                    }
                                }
                                else
                                {
                                    map.map[1, 2] = "X";
                                }
                                break;
                            }
                        case ("7"):
                            {
                                if (map.map[2, 0] == "X" || map.map[2, 0] == "O")
                                {
                                    if (b1 == "7")
                                    {
                                        Console.WriteLine($"{player1.Name} , The place is already taken ! , enter correct value");
                                        goto A;
                                    }
                                }
                                else
                                {
                                    map.map[2, 0] = "X";
                                }
                                break;
                            }
                        case ("8"):
                            {
                                if (map.map[2, 1] == "X" || map.map[2, 1] == "O")
                                {
                                    if (b1 == "8")
                                    {
                                        Console.WriteLine($"{player1.Name} , The place is already taken ! , enter correct value");
                                        goto A;
                                    }
                                }
                                else
                                {
                                    map.map[2, 1] = "X";
                                }
                                break;
                            }
                        case ("9"):
                            {
                                if (map.map[2, 2] == "X" || map.map[2, 2] == "O")
                                {
                                    if (b1 == "9")
                                    {
                                        Console.WriteLine($"{player1.Name} , The place is already taken ! , enter correct value");
                                        goto A;
                                    }
                                }
                                else
                                {
                                    map.map[2, 2] = "X";
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine($"{player1.Name} , Vates ? ");
                                goto A;                                
                            }
                            
                    }
                    moves++;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"\n{player2.Name} , Your turn (you put O)\nEnter number from 1 to 9");
                    B:  string b2 = player2.InsertPlayer();
                    switch (b2)
                    {
                        case ("1"):
                            {
                                if (map.map[0, 0] == "X" || map.map[0, 0] == "O")
                                {
                                    if (b2 == "1")
                                    {
                                        Console.WriteLine($"{player2.Name} , The place is already taken ! , enter correct value");
                                        goto B;
                                    }
                                }
                                else
                                {
                                    map.map[0, 0] = "O";
                                }
                                break;
                            }
                        case ("2"):
                            {
                                if (map.map[0, 1] == "X" || map.map[0, 1] == "O")
                                {
                                    if (b2 == "2")
                                    {
                                        Console.WriteLine($"{player2.Name} , The place is already taken ! , enter correct value");
                                        goto B;
                                    }
                                }
                                else
                                {
                                    map.map[0, 1] = "O";
                                }
                                break;
                            }
                        case ("3"):
                            {
                                if (map.map[0, 2] == "X" || map.map[0, 2] == "O")
                                {
                                    if (b2 == "3")
                                    {
                                        Console.WriteLine($"{player2.Name} , The place is already taken ! , enter correct value");
                                        goto B;
                                    }
                                }
                                else
                                {
                                    map.map[0, 2] = "O";
                                }
                                break;
                            }
                        case ("4"):
                            {
                                if (map.map[1, 0] == "X" || map.map[1, 0] == "O")
                                {
                                    if (b2 == "4")
                                    {
                                        Console.WriteLine($"{player2.Name} , The place is already taken ! , enter correct value");
                                        goto B;
                                    }
                                }
                                else
                                {
                                    map.map[1, 0] = "O";
                                }
                                break;
                            }
                        case ("5"):
                            {
                                if (map.map[1, 1] == "X" || map.map[1, 1] == "O")
                                {
                                    if (b2 == "5")
                                    {
                                        Console.WriteLine($"{player2.Name} , The place is already taken ! , enter correct value");
                                        goto B;
                                    }
                                }
                                else
                                {
                                    map.map[1, 1] = "O";
                                }
                                break;
                            }
                        case ("6"):
                            {
                                if (map.map[1, 2] == "X" || map.map[1, 2] == "O")
                                {
                                    if (b2 == "6")
                                    {
                                        Console.WriteLine($"{player2.Name} , The place is already taken ! , enter correct value");
                                        goto B;
                                    }
                                }
                                else
                                {
                                    map.map[1, 2] = "O";
                                }
                                break;
                            }
                        case ("7"):
                            {
                                if (map.map[2, 0] == "X" || map.map[2, 0] == "O")
                                {
                                    if (b2 == "7")
                                    {
                                        Console.WriteLine($"{player2.Name} , The place is already taken ! , enter correct value");
                                        goto B;
                                    }
                                }
                                else
                                {
                                    map.map[2, 0] = "O";
                                }
                                break;
                            }
                        case ("8"):
                            {
                                if (map.map[2, 1] == "X" || map.map[2, 1] == "O")
                                {
                                    if (b2 == "8")
                                    {
                                        Console.WriteLine($"{player2.Name} , The place is already taken ! , enter correct value");
                                        goto B;
                                    }
                                }
                                else
                                {
                                    map.map[2, 1] = "O";
                                }
                                break;
                            }
                        case ("9"):
                            {
                                if (map.map[2, 2] == "X" || map.map[2, 2] == "O")
                                {
                                    if (b2 == "9")
                                    {
                                        Console.WriteLine($"{player2.Name} , The place is already taken ! , enter correct value");
                                        goto B;
                                    }
                                }
                                else
                                {
                                    map.map[2, 2] = "O";
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine($"{player2.Name} , Vates ? ");
                                goto B;
                            }
                    }
                    moves++;
                }
                Console.Clear();
                map.ViewMap();

                if(IfPlayer1Wins())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n\n{player1.Name} Wins The Game !!");
                    Console.ReadLine();
                    return;
                }
                if (IfPlayer2Wins())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n\n{player2.Name} Wins The Game !!");
                    Console.ReadLine();
                    return;
                }
                if (Draw(moves))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\nNichyaaaa :D");
                    Console.ReadLine();
                    return;
                }
            }
            


        }
    }
}
