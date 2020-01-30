using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKataAndy.PriceCalculators
{
    public interface IPriceCalculator
    {
        decimal CalculatePriceForItem(ItemType itemType, int quatity);
    }
}
