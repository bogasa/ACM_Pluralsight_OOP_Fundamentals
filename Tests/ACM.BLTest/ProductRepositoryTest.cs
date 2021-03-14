using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers"
            };
            //act
            var actual = productRepository.Retrieve(2);
            //assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestM()
        {
            //arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };
            //act
            var actual = productRepository.Save(updateProduct);
            //assert
            Assert.AreEqual(false, actual);
        }
    }
}
