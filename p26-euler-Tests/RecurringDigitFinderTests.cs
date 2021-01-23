using Microsoft.VisualStudio.TestTools.UnitTesting;
using p26_euler;

namespace p26_euler_Tests
{
    [TestClass]
    public class RecurringDigitFinderTests
    {        
        RecurringDigitFinder rdf = new RecurringDigitFinder(2);


        [TestMethod]
        public void Test1_div_2()
        {
            rdf.Denominator = 2;

            Assert.AreEqual(0, rdf.GetRecuringCycleCount());

        }

        [TestMethod]
        public void Test1_div_3()
        {
            rdf.Denominator = 3;

            Assert.AreEqual(1, rdf.GetRecuringCycleCount());

        }

        [TestMethod]
        public void Test1_div_4()
        {
            rdf.Denominator = 4;

            Assert.AreEqual(0, rdf.GetRecuringCycleCount());

        }

        [TestMethod]
        public void Test1_div_5()
        {
            rdf.Denominator = 5;

            Assert.AreEqual(0, rdf.GetRecuringCycleCount());

        }

        [TestMethod]
        public void Test1_div_6()
        {
            rdf.Denominator = 6;

            Assert.AreEqual(1, rdf.GetRecuringCycleCount());

        }

        [TestMethod]
        public void Test1_div_7()
        {
            rdf.Denominator = 7;

            Assert.AreEqual(6, rdf.GetRecuringCycleCount());

        }

        [TestMethod]
        public void Test1_div_8()
        {
            rdf.Denominator = 8;

            Assert.AreEqual(0, rdf.GetRecuringCycleCount());

        }

        [TestMethod]
        public void Test1_div_9()
        {
            rdf.Denominator = 9;

            Assert.AreEqual(1, rdf.GetRecuringCycleCount());

        }

        [TestMethod]
        public void Test1_div_10()
        {
            rdf.Denominator = 10;

            Assert.AreEqual(0, rdf.GetRecuringCycleCount());

        }


        [TestMethod]
        public void Test1_div_11()
        {
            rdf.Denominator = 11;

            Assert.AreEqual(2, rdf.GetRecuringCycleCount());


        }

        [TestMethod]
        public void Test1_div_111()
        {
            rdf.Denominator = 111;

            Assert.AreEqual(3, rdf.GetRecuringCycleCount());

        }

        [TestMethod]
        public void Test1_div_879()
        {
            rdf.Denominator = 879;

            Assert.AreEqual(0, rdf.GetRecuringCycleCount());

        }
    }
}
