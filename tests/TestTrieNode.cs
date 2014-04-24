using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BookParser_Trie.tests
{

    [TestFixture]
    class TestTrieNode
    {

        [Test]
        public void TestaddSameChar()
        {
            TrieNode root_node = new TrieNode(' ', null);

            root_node.add('a');
            TrieNode node = root_node.add('a');

            string actual = node.getWord();
            string expected = "a";

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestaddnewChar()
        {
            TrieNode node = new TrieNode(' ', null);
            node = node.add('a');
            node = node.add('b');

            string actual = node.getWord();
            string expected = "ab";

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);

            Assert.AreEqual(0, node.word_count,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestaddWordCountToDictionary()
        {
            Dictionary<string, int> dt = new Dictionary<string, int>();
            string[] words = { "cat", "dog", "cattle", "cat" };
            TrieNode root_node = createTrie(words);

            root_node.addWordCountToDictionary(ref dt);
            var actual = dt["cat"];
            int expected = 2;

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);

        }

        // creates trie and returns root node
        public static TrieNode createTrie(string[] words)
        {
            TrieNode root_node = new TrieNode(' ', null);

            foreach (string word in words)
            {
                TrieNode start_node = root_node;
                foreach (char c in word.ToCharArray())
                {
                    start_node = start_node.add(c);
                }
                ++start_node.word_count;
            }
            return root_node;
        }

        [Test]
        public void TestgetWordRoot()
        {
            TrieNode node = new TrieNode(' ', null);

            string actual = node.getWord();
            string expected = "";

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestgetWord()
        {
            TrieNode node = new TrieNode(' ', null);

            foreach (char c in "cat".ToArray())
            {
                node  = node.add(c);
            }

            string actual = node.getWord();
            string expected = "cat";

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        // [more about getWord()]
        // no cyclic dependencies possible as it should be set at obj creations
        // and cannot set parents explicitly

    }
}
