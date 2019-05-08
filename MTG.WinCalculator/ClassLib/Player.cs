using System;

namespace ClassLib
{
    public class Player
    {
        public Player()
        {
            StartingLifeTotal = 20;
        }
        public Player(string name, string startingLifeTotal)
        {
            Name              = name;

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