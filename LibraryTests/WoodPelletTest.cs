using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoodPelletsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPelletTests
{
    [TestClass()]
    public class WoodPelletTest
    {
        [TestMethod()]
        public void ValidateBrandTest()
        {
            WoodPellet test1 = new WoodPellet() { Id = 1, Brand = "Super Duper Supreme", Price = 100, Quality = 1 };
            test1.ValidateBrand();

            WoodPellet test2 = new WoodPellet() { Id = 2, Brand = null, Price = 200, Quality = 1 };
            Assert.ThrowsException<ArgumentNullException>(
                () => test2.ValidateBrand());

            WoodPellet test3 = new WoodPellet() { Id = 3, Brand = "ab", Price = 300, Quality = 1 };
            Assert.ThrowsException<ArgumentException>(
                               () => test3.ValidateBrand());

            WoodPellet book4 = new WoodPellet() { Id = 4, Brand = "abc", Price = 300, Quality = 1 };
            test1.ValidateBrand();

        }

        [TestMethod()]
        public void ValidateQuality()
        {
            WoodPellet test1 = new WoodPellet() { Id = 1, Brand = "Super Duper Supreme", Price = 100, Quality = 1 };
            test1.ValidateQuality();

            WoodPellet test2 = new WoodPellet() { Id = 2, Brand = "Super Duper Supreme", Price = 200, Quality = null };
            Assert.ThrowsException<ArgumentNullException>(
                               () => test2.ValidateQuality());

            WoodPellet test3 = new WoodPellet() { Id = 3, Brand = "Super Duper Supreme", Price = 300, Quality = 0 };
            Assert.ThrowsException<ArgumentException>(
                               () => test3.ValidatePrice());

            WoodPellet test4 = new WoodPellet() { Id = 4, Brand = "Super Duper Supreme", Price = 400, Quality = 6 };
            Assert.ThrowsException<ArgumentException>(
                               () => test4.ValidatePrice());

        }




    }
}
