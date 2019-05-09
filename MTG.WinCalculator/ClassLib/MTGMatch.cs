using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class MtgMatch
    {
        public MtgMatch()
        {
            ListOfPlayers = new List<Player>();
        }

        public List<Player> ListOfPlayers { get; set; }

        public void AddPlayerToMatch(Player player)
        {
            ListOfPlayers.Add(player);
        }

        public void RemovePlayerFromMatch(Player player)
        {
            ListOfPlayers.Remove(player);
        }
    }
}
