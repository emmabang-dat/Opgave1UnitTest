using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1UnitTestTests
{
    [TestClass()]
    public class CarTests
    {
        private Car _car;
        [TestInitialize()]
        public void SuperCarTest()
        {
            _car = new Car(id: 1, model: "Tesla", price: 10000, licensePlate: "AB23780");
        }

        [TestMethod()]
        public void ModelTest()
        {
            Assert.AreEqual("Tesla", _car.Model);
            Assert.ThrowsException<ArgumentException>(() => _car.Model = "BMW");
            Assert.ThrowsException<ArgumentNullException>(() => _car.Model = null);
        }
        [TestMethod()]
        public void PriceTest()
        {
            Assert.AreEqual( 10000, _car.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.Price = -1);
        }

        [TestMethod()]
        public void LicensePlateTest()
        {
            Assert.AreEqual( "AB23780",  _car.LicensePlate);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.LicensePlate = "he");
            Assert.ThrowsException<ArgumentNullException>(() => _car.LicensePlate = null);
        }
    }
}