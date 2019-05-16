using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib.Enums;

namespace ClassLib.Interfaces
{
    public interface ICard
    {
        string        Name        { get; set; }
        string        Cost        { get; set; }
        CardSuperType Type        { get; set; }
        bool          IsLegendary { get; set; }
    }
}
