using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Soccersolution
{
    internal class Team
    {
        Player[] players;
        int numOfPlayers;
        public bool isFull => numOfPlayers == 6;

        internal Player[] Players { get => players;}
        public int NumOfPlayers { get => numOfPlayers;}

        public Team()
        {
            this.players = new Player[6];
            this.numOfPlayers = 0;

        }

        public bool isIncluded (Player p)
        {
            foreach (var player in players) 
            { 
                if(player != null && p.Name==player.Name && p.Pos == player.Pos)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isAvailable (Player p) 
        {
            if (isIncluded(p))
            {
                return false;
            }

            int count = 0;

            foreach (Player player in players)
            {
                if (player != null && player.Pos == p.Pos)
                {
                    count++;
                }
            }


            switch (p.Pos)
            {
                case Position.Goalkeeper:
                    return count == 0;
                case Position.Defender:
                    return count == 0;

                case Position.Midfielder:
                    return count < 2;
                case Position.Scorer:
                    return count < 2;

                default:
                    return false;
            }
        }

        public void Include(Player p)
        {
            if(!isFull && isAvailable(p))
            {
                players[numOfPlayers] = p;
                numOfPlayers++;
            }
        }

    }
}
