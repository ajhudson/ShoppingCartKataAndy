using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartKataAndy.PriceCalculators;
using ShoppingCartKataAndy.ShoppingCarts;

namespace ShoppingCartKataAndy.Tests
{
    [TestClass]
    public class ShoppingCartTests
    {
        private IShoppingCart shoppingCart;

        public ShoppingCartTests()
        {
            var priceCalculator = new PriceCalculator();
            this.shoppingCart = new ShoppingCart(priceCalculator);
        }

        [TestMethod]
        public void IfIsEmptyIsCalledThenItReturnsTrueIfNoItems()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsTrue(shoppingCart.IsEmpty);
        }

        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataRow(3, 3)]
        public void IfAddItemIsCalledThenItemIsAdded(int quantity, int expectedNumberOfItems)
        {
            // Arrange
            this.shoppingCart.Empty();

            // Act
            this.shoppingCart.AddItem(ItemType.Chip, quantity);

            // Assert
            Assert.AreEqual(expectedNumberOfItems, this.shoppingCart.NumberOfIndividualItems);
        }

        [TestMethod]
        public void IfEmptyIsCalledThenBasketIsEmpty()
        {
            // Arrange
            this.shoppingCart.AddItem(ItemType.Pie);
            bool isEmptyBefore = this.shoppingCart.IsEmpty;

            // Act
            this.shoppingCart.Empty();

            // Assert
            Assert.IsFalse(isEmptyBefore);
            Assert.IsTrue(this.shoppingCart.IsEmpty);
        }

        [TestMethod]
        public void IfCalculateTotalIsCalledThenTotalIsCorrect()
        {
            // Arrange
            var priceCalc = new PriceCalculator();

            this.shoppingCart.AddItem(ItemType.Chip, 4);
            this.shoppingCart.AddItem(ItemType.Pie, 1);
            this.shoppingCart.AddItem(ItemType.Sausage, 2);

            // Act
            decimal result = this.shoppingCart.CalculateTotal();

            // Assert

            Assert.AreEqual(5.5M, result);
        }
    }
}
