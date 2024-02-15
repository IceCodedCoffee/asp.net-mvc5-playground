using EssentialTools.Models;
using EssentialTools.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;

namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest2
    {
        private Product[] products = 
        {
             new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
             new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
             new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
             new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };

        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            Mock<IDiscountHelper> mock = new Mock<IDiscountHelper>();

            mock.Setup(m => m.ApplyDiscount(It.IsAny<decimal>())).Returns<decimal>(total => total);

            var testObject = new LinqValueCalculator(mock.Object);

            // act
            var result = testObject.ValueProducts(products);

            // assert
            Assert.AreEqual(products.Sum(e => e.Price), result);
        }
    }
}