using ShoppingCartKataAndy.PriceCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKataAndy.ShoppingCarts
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly Dictionary<ItemType, int> items;

        private readonly IPriceCalculator priceCalculator;

        public ShoppingCart(IPriceCalculator priceCalculator)
        {
            this.items = new Dictionary<ItemType, int>();
            this.priceCalculator = priceCalculator;
        }

        public bool IsEmpty => !this.items.Any();

        public int NumberOfItemTypes => this.items.Count();

        public int NumberOfIndividualItems => this.items.Select(item => item.Value).Sum();

        public void AddItem(ItemType itemType, int quantity = 1)
        {
            if (!this.items.ContainsKey(itemType))
            {
                this.items.Add(itemType, quantity);
            } 
            else
            {
                this.items[itemType] += quantity;
            }
        }

        public decimal CalculateTotal()
        {
            decimal result = this.items.Select(x => this.priceCalculator.CalculatePriceForItem(x.Key, x.Value)).Sum();

            return result;
        }

        public void Empty()
        {
            this.items.Clear();
        }

        public void RemoveItem(ItemType itemType, int quantity = 1)
        {
            throw new NotImplementedException();
        }
    }
}
