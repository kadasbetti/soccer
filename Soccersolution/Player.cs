using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccersolution
{
    internal class Player
    {
        string name;
        Position pos;

        public Player(string name, Position pos)
        {
            this.name = name;
            this.pos = pos;
        }

        public string Name { get => name; }
        public Position Pos { get => pos;}

        public override string ToString()
        {
            return $"{Name} - {Pos}";
        }
    }
}
