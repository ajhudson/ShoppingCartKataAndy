using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartKataAndy.PriceCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKataAndy.Tests
{
    [TestClass]
    public class PriceCalculatorTests
    {
        private IPriceCalculator priceCalculator;

        [TestInitialize]
        public void SetUp()
        {
            this.priceCalculator = new PriceCalculator();
        }

        [TestMethod]
        public void IfCalculatePriceForChipItemIsCalledThePriceIsCalculated()
        {
            // Arrange

            // Act
            decimal result = this.priceCalculator.CalculatePriceForItem(ItemType.Chip, 3);

            // Assert
            Assert.AreEqual(0.75M, result);
        }
    }
}
