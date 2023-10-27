using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodPelletsLib;

namespace WoodPelletLib.Tests
{
    [TestClass]
    public class RepositoryTest
    {

        [TestMethod()]
        public void AddTest()
        {
            WoodPelletRepository testrepo = new WoodPelletRepository();
            WoodPellet test = new WoodPellet() { Id = 1, Brand = "Super Duper Supreme", Price = 100, Quality = 1 };
            testrepo.Add(test);
            //Assert.AreEqual(6, testrepo.Get().Count);
        }

    }
}
