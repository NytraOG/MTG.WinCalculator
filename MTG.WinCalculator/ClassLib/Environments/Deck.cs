using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib.Interfaces;

namespace ClassLib.Environments
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<ICard>();
        }

        public List<ICard> Cards { get; }


    }
}
