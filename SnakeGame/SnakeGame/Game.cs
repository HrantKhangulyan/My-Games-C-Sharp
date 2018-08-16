using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Game
    {
        Random rnd = new Random();        

        public Map map = new Map(9,9);
        
        public int rnd1;
        public int rnd2;

        public void GeneateRandom()
        {
            while (true)
            {
                rnd1 = rnd.Next(0, map.size1);
                rnd2 = rnd.Next(0, map.size2);

                if (map.TheMap[rnd1,rnd2] == '-')
                {
                    map.TheMap[rnd1, rnd2] = '*';
                    return;
                }
            }           
        }
    }
}
