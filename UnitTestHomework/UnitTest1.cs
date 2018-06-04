using System;
using aucassin_04_june_18_homework__UnitTest_;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHomework
{
    [TestClass]
    public class UnitTest1
    {
        Library lib = new Library();
        Driver testDriver = new Driver();
        Scientist testScientist = new Scientist();
        Villain testVillain = new Villain();
        [TestMethod]
        public void TestMethodUnique()
        {
            CollectionAssert.AllItemsAreUnique(lib.Books);
        }
        [TestMethod]
        public void TestMethodContains()
        {
            CollectionAssert.Contains(lib.Books, "book3");
        }
        [TestMethod]
        public void TestMethodInstance()
        {
            Assert.IsInstanceOfType(testDriver, typeof(Person));
            Assert.IsInstanceOfType(testScientist, typeof(Person));
            Assert.IsInstanceOfType(testVillain, typeof(Person));
        }

    }
}
