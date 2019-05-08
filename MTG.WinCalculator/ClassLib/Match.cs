using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Match
    {
        public Match()
        {
            ListOfPlayers = new List<Player>();
        }

        public List<Player> ListOfPlayers { get; set; }

        public void AddPlayerToMatch(Player player)
        {
            ListOfPlayers.Add(player);
        }
    }
}
