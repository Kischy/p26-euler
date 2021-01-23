using Microsoft.VisualStudio.TestTools.UnitTesting;
using p26_euler;
using System.Collections.Generic;


namespace p26_euler_Tests
{
    [TestClass]
    public class RecurringDigitFinderTests
    {
        [TestMethod]
        public void TestNonRecuring()
        {
            List<int> numbers = new List<int>() { 5, -1 };

            Assert.AreEqual(0, RecurringDigitFinder.GetRecuringCycleCount(numbers));
        }

        [TestMethod]
        public void TestOneRecuringEasy()
        {
            List<int> numbers = new List<int>() { 1,1,1 };

            Assert.AreEqual(1, RecurringDigitFinder.GetRecuringCycleCount(numbers));
        }

        [TestMethod]
        public void TestOneRecuring()
        {
            List<int> numbers = new List<int>() { 0, 1, 6, 6, 6, 6 };

            Assert.AreEqual(1, RecurringDigitFinder.GetRecuringCycleCount(numbers));
        }

        [TestMethod]
        public void TestTwoRecuring()
        {
            List<int> numbers = new List<int>() { 0, 9, 0, 9 };

            Assert.AreEqual(2, RecurringDigitFinder.GetRecuringCycleCount(numbers));
        }

        [TestMethod]
        public void TestSixRecuring()
        {
            List<int> numbers = new List<int>() { 1, 4, 2, 8, 5, 7, 1, 4, 2, 8, 5, 7 };

            Assert.AreEqual(6, RecurringDigitFinder.GetRecuringCycleCount(numbers));
        }
    }
}