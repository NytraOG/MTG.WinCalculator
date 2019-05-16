using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib.Environments;
using ClassLib.Interfaces;

namespace ClassLib.Manager
{
    public class DeckManager
    {
        public Deck AddCardsToDeck(int amountToAdd, ICard cardToAdd, Deck deck)
        {
            if (amountToAdd <= 0 || amountToAdd > 60)
                throw new Exception($"Can't add \"{amountToAdd}\" Cards to a Deck!");

            for (int i = 0; i < amountToAdd; i++)
            {
                deck.Cards.Add(cardToAdd);
            }

            return deck;
        }
    }
}
