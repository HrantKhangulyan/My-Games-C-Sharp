using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Map
    {
        public char[,] TheMap;
        public int size1;
        public int size2;


        public Map(int size1, int size2)
        {
            this.size1 = size1;
            this.size2 = size2;
            TheMap = new char[size1, size2];
        }

        public Map() { }

        public void CreateMap()
        {
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    TheMap[i, j] = '-';
                }
            }            
        }

        public void VievMap()
        {
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    if (TheMap[i,j] == '>' || TheMap[i, j] == '<' || TheMap[i, j] == '^' || TheMap[i, j] == 'v' || TheMap[i, j] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    if (TheMap[i, j] == '*')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.Write(TheMap[i, j] + " ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine();
            }
        }

    }
}
