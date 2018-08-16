using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Snake
    {
        public int Xpos;
        public int Ypos;
        public int[] Xmapmemory;
        public int[] Ymapmemory;
        public Game game = new Game();
        Map map;

        public Snake()
        {
            this.Xpos = 0;
            this.Ypos = 0;
            map = game.map;
            Xmapmemory = new int[4000000];
            Ymapmemory = new int[4000000];
        }


        public void Move()
        {
            int difficulty = 280;
            int score = 0;
            int moves = 0;
            int maxscore = map.size1 * map.size2 - 1;
            int l = 0, k = 0;
            map.CreateMap();
            map.TheMap[0, 0] = '>';
            game.GeneateRandom();
            map.VievMap();
            ConsoleKeyInfo cki = Console.ReadKey();
            ConsoleKey i = cki.Key;
            while (i != ConsoleKey.Escape)
            {
                Console.Clear();
                map.VievMap();
                Console.ForegroundColor = ConsoleColor.Green;
                if (score == maxscore)
                {
                    Console.WriteLine("\t\t\tCongratulations You Won ! (inch el haves unes)");
                    Console.WriteLine("\t\t\t\t\t  Enter sxmi");
                    Console.ReadLine();
                    return;
                }

                moves++;
                switch (i)
                {
                    case (ConsoleKey.RightArrow):
                        while (!Console.KeyAvailable)
                        {
                            if (score == 0)
                            {
                                map.TheMap[Xpos, Ypos] = '-';
                            }
                            else
                            {
                                map.TheMap[Xpos, Ypos] = 'O';
                            }

                            if (++Ypos >= map.size2)
                            {
                                Ypos = 0;
                                if (map.TheMap[Xpos, Ypos] == '*')
                                {
                                    map.TheMap[Xpos, Ypos] = '>';
                                    Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                    score++;
                                    if (score != maxscore)
                                    {
                                        game.GeneateRandom();
                                    }
                                }
                                else
                                {
                                    if (map.TheMap[Xpos, Ypos] == 'O' && (Xpos != Xmapmemory[k] && Ymapmemory[k] != Xpos))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t\t\t\t\tYou lost maaan :(");
                                        Console.ReadLine();
                                        return;
                                    }
                                    if (score != 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = '>';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        map.TheMap[Xmapmemory[k], Ymapmemory[k]] = '-'; k++;
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = '>';
                                    }
                                }
                            }
                            else
                            {
                                if (map.TheMap[Xpos, Ypos] == 'O' && (Xpos != Xmapmemory[k] && Ymapmemory[k] != Xpos))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\t\t\t\t\tYou lost maaan :(");
                                    Console.ReadLine();
                                    return;
                                }

                                if (map.TheMap[Xpos, Ypos] == '*')
                                {
                                    if (score == 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = '>';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos - 1;
                                        map.TheMap[Xmapmemory[l], Ymapmemory[l]] = 'O';
                                        l++;
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos;
                                        score++; l++;
                                        if (score != maxscore)
                                        {
                                            game.GeneateRandom();
                                        }
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = '>';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        score++;
                                        if (score != maxscore)
                                        {
                                            game.GeneateRandom();
                                        }
                                    }
                                }
                                else
                                {
                                    if (score != 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = '>';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        map.TheMap[Xmapmemory[k], Ymapmemory[k]] = '-'; k++;
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = '>';
                                    }
                                }
                            }
                            Console.Clear();
                            map.VievMap();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Your score is {score}/{maxscore}\nPress Esc to exit");
                            System.Threading.Thread.Sleep(difficulty);
                        }
                        i = Console.ReadKey(true).Key;
                        break;

                    case (ConsoleKey.LeftArrow):
                        while (!Console.KeyAvailable)
                        {
                            if (score == 0)
                            {
                                map.TheMap[Xpos, Ypos] = '-';
                            }
                            else
                            {
                                map.TheMap[Xpos, Ypos] = 'O';
                            }

                            if (--Ypos < 0)
                            {
                                Ypos = map.size2 - 1;
                                if (map.TheMap[Xpos, Ypos] == '*')
                                {
                                    map.TheMap[Xpos, Ypos] = '<';
                                    Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                    score++;
                                    if (score != maxscore)
                                    {
                                        game.GeneateRandom();
                                    }
                                }
                                else
                                {
                                    if (map.TheMap[Xpos, Ypos] == 'O')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t\t\t\t\tYou lost maaan :(");
                                        Console.ReadLine();
                                        return;
                                    }
                                    if (score != 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = '<';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        map.TheMap[Xmapmemory[k], Ymapmemory[k]] = '-'; k++;
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = '<';
                                    }
                                }
                            }
                            else
                            {
                                if (map.TheMap[Xpos, Ypos] == 'O')
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\t\t\t\t\tYou lost maaan :(");
                                    Console.ReadLine();
                                    return;
                                }

                                if (map.TheMap[Xpos, Ypos] == '*')
                                {
                                    if (score == 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = '<';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos + 1;
                                        map.TheMap[Xmapmemory[l], Ymapmemory[l]] = 'O';
                                        l++;
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos;
                                        score++; l++;
                                        if (score != maxscore)
                                        {
                                            game.GeneateRandom();
                                        }
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = '<';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        score++;
                                        if (score != maxscore)
                                        {
                                            game.GeneateRandom();
                                        }
                                    }
                                }
                                else
                                {
                                    if (score != 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = '<';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        map.TheMap[Xmapmemory[k], Ymapmemory[k]] = '-'; k++;
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = '<';
                                    }
                                }
                            }
                            Console.Clear();
                            map.VievMap();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Your score is {score}/{maxscore}\nPress Esc to exit");
                            System.Threading.Thread.Sleep(difficulty);
                        }
                        i = Console.ReadKey(true).Key;
                        break;

                    case (ConsoleKey.UpArrow):
                        while (!Console.KeyAvailable)
                        {
                            if (score == 0)
                            {
                                map.TheMap[Xpos, Ypos] = '-';
                            }
                            else
                            {
                                map.TheMap[Xpos, Ypos] = 'O';
                            }

                            if (--Xpos < 0)
                            {
                                Xpos = map.size1 - 1;
                                if (map.TheMap[Xpos, Ypos] == '*')
                                {
                                    map.TheMap[Xpos, Ypos] = '^';
                                    Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                    score++;
                                    if (score != maxscore)
                                    {
                                        game.GeneateRandom();
                                    }
                                }
                                else
                                {
                                    if (map.TheMap[Xpos, Ypos] == 'O')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t\t\t\t\tYou lost maaan :(");
                                        Console.ReadLine();
                                        return;
                                    }
                                    if (score != 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = '^';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        map.TheMap[Xmapmemory[k], Ymapmemory[k]] = '-'; k++;
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = '^';
                                    }
                                }
                            }
                            else
                            {
                                if (map.TheMap[Xpos, Ypos] == 'O')
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\t\t\t\t\tYou lost maaan :(");
                                    Console.ReadLine();
                                    return;
                                }

                                if (map.TheMap[Xpos, Ypos] == '*')
                                {
                                    if (score == 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = '^';
                                        Xmapmemory[l] = Xpos + 1; Ymapmemory[l] = Ypos;
                                        map.TheMap[Xmapmemory[l], Ymapmemory[l]] = 'O';
                                        l++;
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos;
                                        score++; l++;
                                        if (score != maxscore)
                                        {
                                            game.GeneateRandom();
                                        }
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = '^';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        score++;
                                        if (score != maxscore)
                                        {
                                            game.GeneateRandom();
                                        }
                                    }
                                }
                                else
                                {
                                    if (score != 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = '^';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        map.TheMap[Xmapmemory[k], Ymapmemory[k]] = '-'; k++;
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = '^';
                                    }
                                }
                            }
                            Console.Clear();
                            map.VievMap();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Your score is {score}/{maxscore}\nPress Esc to exit");
                            System.Threading.Thread.Sleep(difficulty);
                        }
                        i = Console.ReadKey(true).Key;

                        break;

                    case (ConsoleKey.DownArrow):
                        while (!Console.KeyAvailable)
                        {
                            if (score == 0)
                            {
                                map.TheMap[Xpos, Ypos] = '-';
                            }
                            else
                            {
                                map.TheMap[Xpos, Ypos] = 'O';
                            }

                            if (++Xpos >= map.size1)
                            {
                                Xpos = 0;
                                if (map.TheMap[Xpos, Ypos] == '*')
                                {
                                    map.TheMap[Xpos, Ypos] = 'v';
                                    Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                    score++;
                                    if (score != maxscore)
                                    {
                                        game.GeneateRandom();
                                    }
                                }
                                else
                                {
                                    if (map.TheMap[Xpos, Ypos] == 'O')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t\t\t\t\tYou lost maaan :(");
                                        Console.ReadLine();
                                        return;
                                    }
                                    if (score != 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = 'v';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        map.TheMap[Xmapmemory[k], Ymapmemory[k]] = '-'; k++;
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = 'v';
                                    }
                                }
                            }
                            else
                            {
                                if (map.TheMap[Xpos, Ypos] == 'O')
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\t\t\t\t\tYou lost maaan :(");
                                    Console.ReadLine();
                                    return;
                                }

                                if (map.TheMap[Xpos, Ypos] == '*')
                                {
                                    if (score == 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = 'v';
                                        Xmapmemory[l] = Xpos - 1; Ymapmemory[l] = Ypos;
                                        map.TheMap[Xmapmemory[l], Ymapmemory[l]] = 'O';
                                        l++;
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos;
                                        score++; l++;
                                        if (score != maxscore)
                                        {
                                            game.GeneateRandom();
                                        }
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = 'v';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        score++;
                                        if (score != maxscore)
                                        {
                                            game.GeneateRandom();
                                        }
                                    }
                                }
                                else
                                {
                                    if (score != 0)
                                    {
                                        map.TheMap[Xpos, Ypos] = 'v';
                                        Xmapmemory[l] = Xpos; Ymapmemory[l] = Ypos; l++;
                                        map.TheMap[Xmapmemory[k], Ymapmemory[k]] = '-'; k++;
                                    }
                                    else
                                    {
                                        map.TheMap[Xpos, Ypos] = 'v';
                                    }
                                }
                            }
                            Console.Clear();
                            map.VievMap();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"Your score is {score}/{maxscore}\nPress Esc to exit");
                            System.Threading.Thread.Sleep(difficulty);
                        }
                        i = Console.ReadKey(true).Key;

                        break;
                }
            }
        }
    }
}
