using Microsoft.VisualStudio.TestTools.UnitTesting;
using p26_euler;
using System.Collections.Generic;

namespace p26_euler_Tests
{
    [TestClass]
    public class UnitFractionDecimalRepresentationTests
    {

        UnitFractionDecimalRepresentation ufdr = new UnitFractionDecimalRepresentation(2);


        [TestMethod]
        public void TestToLowNumberThrowsArgumentException()
        {
            Assert.ThrowsException<System.ArgumentException>(() => new UnitFractionDecimalRepresentation(1));

        }

        [TestMethod]
        public void Test1_div_2()
        {
            ufdr.Denominator = 2;

            Assert.AreEqual(5, ufdr.GetNextDigit());
            Assert.AreEqual(-1, ufdr.GetNextDigit());
            Assert.AreEqual(-1, ufdr.GetNextDigit());


            List<int> ex_remain = new List<int>(){1,0};

            CollectionAssert.AreEqual(ex_remain, ufdr.Remainders);
        }

        [TestMethod]
        public void Test1_div_3()
        {
            ufdr.Denominator = 3;

            Assert.AreEqual(3, ufdr.GetNextDigit());
            Assert.AreEqual(3, ufdr.GetNextDigit());
            Assert.AreEqual(3, ufdr.GetNextDigit());

            List<int> ex_remain = new List<int>() { 1, 1, 1, 1 };

            CollectionAssert.AreEqual(ex_remain, ufdr.Remainders);
        }

        [TestMethod]
        public void Test1_div_4()
        {
            ufdr.Denominator = 4;

            Assert.AreEqual(2, ufdr.GetNextDigit());
            Assert.AreEqual(5, ufdr.GetNextDigit());
            Assert.AreEqual(-1, ufdr.GetNextDigit());

            List<int> ex_remain = new List<int>() { 1, 2, 0 };

            CollectionAssert.AreEqual(ex_remain, ufdr.Remainders);

        }

        [TestMethod]
        public void Test1_div_5()
        {
            ufdr.Denominator = 5;

            Assert.AreEqual(2, ufdr.GetNextDigit());
            Assert.AreEqual(-1, ufdr.GetNextDigit());
            Assert.AreEqual(-1, ufdr.GetNextDigit());
        }

        [TestMethod]
        public void Test1_div_6()
        {
            ufdr.Denominator = 6;

            Assert.AreEqual(1, ufdr.GetNextDigit());
            Assert.AreEqual(6, ufdr.GetNextDigit());
            Assert.AreEqual(6, ufdr.GetNextDigit());
            Assert.AreEqual(6, ufdr.GetNextDigit());
        }

        [TestMethod]
        public void Test1_div_7()
        {
            ufdr.Denominator = 7;

            Assert.AreEqual(1, ufdr.GetNextDigit());
            Assert.AreEqual(4, ufdr.GetNextDigit());
            Assert.AreEqual(2, ufdr.GetNextDigit());
            Assert.AreEqual(8, ufdr.GetNextDigit());
            Assert.AreEqual(5, ufdr.GetNextDigit());
            Assert.AreEqual(7, ufdr.GetNextDigit());

            Assert.AreEqual(1, ufdr.GetNextDigit());
            Assert.AreEqual(4, ufdr.GetNextDigit());
            Assert.AreEqual(2, ufdr.GetNextDigit());
            Assert.AreEqual(8, ufdr.GetNextDigit());
            Assert.AreEqual(5, ufdr.GetNextDigit());
            Assert.AreEqual(7, ufdr.GetNextDigit());



            List<int> ex_remain = new List<int>() { 1, 3, 2, 6, 4, 5, 1, 3, 2, 6, 4, 5, 1 };

            CollectionAssert.AreEqual(ex_remain, ufdr.Remainders);
        }

        [TestMethod]
        public void Test1_div_8()
        {
            ufdr.Denominator = 8;

            Assert.AreEqual(1, ufdr.GetNextDigit());
            Assert.AreEqual(2, ufdr.GetNextDigit());
            Assert.AreEqual(5, ufdr.GetNextDigit());
            Assert.AreEqual(-1, ufdr.GetNextDigit());
        }

        [TestMethod]
        public void Test1_div_9()
        {
            ufdr.Denominator = 9;

            Assert.AreEqual(1, ufdr.GetNextDigit());
            Assert.AreEqual(1, ufdr.GetNextDigit());
            Assert.AreEqual(1, ufdr.GetNextDigit());
            Assert.AreEqual(1, ufdr.GetNextDigit());
        }

        [TestMethod]
        public void Test1_div_10()
        {
            ufdr.Denominator = 10;

            Assert.AreEqual(1, ufdr.GetNextDigit());
            Assert.AreEqual(-1, ufdr.GetNextDigit());
            Assert.AreEqual(-1, ufdr.GetNextDigit());
        }


        [TestMethod]
        public void Test1_div_11()
        {
            ufdr.Denominator = 11;

            Assert.AreEqual(0, ufdr.GetNextDigit());
            Assert.AreEqual(9, ufdr.GetNextDigit());
            Assert.AreEqual(0, ufdr.GetNextDigit());
            Assert.AreEqual(9, ufdr.GetNextDigit());

        }

        [TestMethod]
        public void Test1_div_111()
        {
            ufdr.Denominator = 111;

            Assert.AreEqual(0, ufdr.GetNextDigit());
            Assert.AreEqual(0, ufdr.GetNextDigit());
            Assert.AreEqual(9, ufdr.GetNextDigit());
            Assert.AreEqual(0, ufdr.GetNextDigit());
            Assert.AreEqual(0, ufdr.GetNextDigit());
            Assert.AreEqual(9, ufdr.GetNextDigit());
        }

        [TestMethod]
        public void Test1_div_879()
        {
            ufdr.Denominator = 879;

            Assert.AreEqual(0, ufdr.GetNextDigit());
            Assert.AreEqual(0, ufdr.GetNextDigit());
            Assert.AreEqual(1, ufdr.GetNextDigit());
            Assert.AreEqual(1, ufdr.GetNextDigit());
            Assert.AreEqual(3, ufdr.GetNextDigit());
            Assert.AreEqual(7, ufdr.GetNextDigit());
            Assert.AreEqual(6, ufdr.GetNextDigit());
            Assert.AreEqual(5, ufdr.GetNextDigit());
            Assert.AreEqual(6, ufdr.GetNextDigit());
            Assert.AreEqual(4, ufdr.GetNextDigit());
            Assert.AreEqual(2, ufdr.GetNextDigit());
            Assert.AreEqual(7, ufdr.GetNextDigit());
            Assert.AreEqual(7, ufdr.GetNextDigit());

        }

    }
}
