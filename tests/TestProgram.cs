using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BookParser_hash.tests
{
    [TestFixture]
    class TestProgram
    {
        [Test]
        public void TestisPrime0()
        {
            bool actual = Program.isPrime(0);
            bool expected = false;

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestisPrime1()
        {
            bool actual = Program.isPrime(1);
            bool expected = false;

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestisPrime2()
        {
            bool actual = Program.isPrime(2);
            bool expected = true;

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestisPrime3()
        {
            bool actual = Program.isPrime(3);
            bool expected = true;

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void TestisPrimeNeg1()
        {
            bool actual = Program.isPrime(-1);
        }

        // other functions can be tested when mocks are set up properly
    }
}
