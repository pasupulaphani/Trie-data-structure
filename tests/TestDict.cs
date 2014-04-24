using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BookParser_hash.tests
{
    [TestFixture]
    class TestDict
    {
        [Test]
        public void TestAddNewItem()
        {
            Dict dict = new Dict();
            
            int actual = dict.add("test");
            int expected = 1;

            Assert.AreEqual(expected, actual,
                "expected 0 for adding new item");
        }

        [Test]
        public void TestAddExitingItem()
        {
            Dict dict = new Dict();
            dict.add("test");

            int actual = dict.add("test");
            int expected = 2;

            Assert.AreEqual(expected, actual,
                "expected 2 for adding 2 times same key");
        }
    }
}
