using NUnit.Framework;

namespace SmartphoneShop.Tests
{
    [TestFixture]
    public class SmartphoneShopTests
    {
        private Smartphone smartphone;
        private Shop shop;
        private string modelName = "iPhone 13 Pro Max";
        private int maximumCharge = 100;
        private int capacity = 3;

        [SetUp]

        public void SetUp()
        {
            smartphone = new Smartphone(modelName,maximumCharge);
            shop = new Shop(3);
        }
        [Test]

        public void Test_Constructor()
        {
            Assert.AreEqual(capacity, shop.Capacity);
            Assert.AreEqual(0, shop.Count);
        }

        [Test]

        public void Test_NegativeOrZeroCapacityShouldThrow()
        {
            Assert.AreEqual(capacity, shop.Capacity);
            Assert.AreEqual(0, shop.Count);
        }
    }
}