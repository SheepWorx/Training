using System;
using Decoupling.LooselyCoupled;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Decoupling.Test
{
    [TestClass]
    public class BasketTest
    {
        [TestMethod]
        public void AddAirtime()
        {
            IProductController customController = new TestProductController();

            Basket basket = new Basket();
            basket.Controller = customController;

            bool itemAdded = basket.AddAirtime();

            Assert.IsTrue(itemAdded);
            Assert.AreEqual(basket.BasketItems.Count, 1);
            Assert.AreEqual(basket.BasketItems[typeof(Airtime).Name].GetType(), typeof(Airtime));
        }
    }
}
