using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_X_And_O_Game
{
    class Map
    {
        public string[,] map;

        public Map()
        {
            map = new string[3, 3];
        }

        public void CreateMap()
        {
            int k = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    map[i, j] = k.ToString();
                    k++;
                }

            }
        }

        public void ViewMap()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("|  ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < 3; j++)
                {
                    if(map[i,j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if(map[i,j] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(map[i, j]);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("  |  ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n-------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

    }
}
