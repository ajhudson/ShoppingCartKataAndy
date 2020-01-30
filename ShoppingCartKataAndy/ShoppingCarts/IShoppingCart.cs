using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKataAndy.ShoppingCarts
{
    public interface IShoppingCart
    {
        bool IsEmpty { get; }

        int NumberOfItemTypes { get; }

        int NumberOfIndividualItems { get; }

        void AddItem(ItemType itemType, int quantity = 1);

        void RemoveItem(ItemType itemType, int quantity = 1);

        decimal CalculateTotal();

        void Empty();

    }
}
