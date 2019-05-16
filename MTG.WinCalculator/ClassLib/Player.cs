using System;
using ClassLib.Interfaces;

namespace ClassLib
{
    public class Player : IPlayCards
    {
        public Player()
        {
            StartingLifeTotal = 20;
            PlayerId          = Guid.NewGuid();
        }

        public Player(string name) : this()
        {
            Name = name;
        }

        public Player(string name, string startingLifeTotal) :this(name)
        {
            if (string.IsNullOrWhiteSpace(startingLifeTotal) || !IsDigitOnly(startingLifeTotal))
            {
                StartingLifeTotal = 20;
            }
            else
            {
                var parsedLifeTotal = int.Parse(startingLifeTotal);

                StartingLifeTotal = parsedLifeTotal > 0 ? parsedLifeTotal : 20;
            }
        }

        public Guid   PlayerId          { get; }
        public string Name              { get; set; }
        public int    StartingLifeTotal { get; set; }

        private static bool IsDigitOnly(string stringToCheck)
        {
            foreach (var c in stringToCheck)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            return true;
        }
    }
}