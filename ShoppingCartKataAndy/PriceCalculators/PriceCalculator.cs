using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKataAndy.PriceCalculators
{
    public class PriceCalculator : IPriceCalculator
    {
        public decimal CalculatePriceForItem(ItemType itemType, int quatity)
        {
            decimal pricePerItem = GetPriceForItem(itemType);

            return pricePerItem * quatity;
        }

        private decimal GetPriceForItem(ItemType itemType)
        {
            switch (itemType)
            {
                case ItemType.Chip:
                    return 0.25M;

                case ItemType.Pie:
                    return 2.50M;

                case ItemType.Sausage:
                    return 1.00M;

                default:
                    return 0M;
            }
        }
    }
}
