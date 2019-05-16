using ClassLib.Enums;
using ClassLib.Interfaces;

namespace ClassLib.Cards
{
    public class BaseCard : ICard
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public CardSuperType Type { get; set; }
        public bool IsLegendary { get; set; }
    }
}
