using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_X_And_O_Game
{
    class Player
    {
        public string Name {get; set;}

        public Player(string name)
        {
            Name = name;
        }

        public string InsertPlayer()
        {
            string ins = Console.ReadLine();
            return ins;
        }
    }
}
