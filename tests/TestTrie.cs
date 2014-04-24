using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BookParser_Trie.tests
{
    [TestFixture]
    class TestTrie
    {
        [Test]
        public void TestAddNewItem()
        {
            Trie trie = new Trie();
            
            int actual = trie.add("test");
            int expected = 1;

            Assert.AreEqual(expected, actual,
                "expected 0 for adding new item");
        }

        [Test]
        public void TestAddExitingItem()
        {
            Trie trie = new Trie();
            trie.add("test");

            int actual = trie.add("test");
            int expected = 2;

            Assert.AreEqual(expected, actual,
                "expected 2 for adding 2 times same key");
        }
    }
}
