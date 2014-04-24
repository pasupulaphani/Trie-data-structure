using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;
using System.Reflection;

namespace BookParser_Trie.tests
{

    [TestFixture]
    class TestWordCount
    {
        [Test]
        public void TestCount1()
        {
            WordCount word_counter = new WordCount(getFileReader("word1count1.txt"), getTrie());
            word_counter.count();

            int actual = (word_counter.getDict())["word1"];
            int expected = 1;

            Assert.AreEqual(expected, actual,
                "expected :"+ expected +" did not match actual :" + actual);
        }

        [Test]
        public void TestCount2()
        {
            WordCount word_counter = new WordCount(getFileReader("word1count2.txt"), getTrie());
            word_counter.count();

            int actual = (word_counter.getDict())["word1"];
            int expected = 2;

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TestWordNotFound()
        {
            WordCount word_counter = new WordCount(getFileReader("word1count1.txt"), getTrie());
            word_counter.count();

            int count = (word_counter.getDict())["word3"];

        }

        // these could be mocked for convinience
        // 
        private static ReadFile getFileReader(string file_name)
        {
            // this is not the proper way but I couldn't findhow to find a file
            string path = Environment.CurrentDirectory + "/../../tests/" + @file_name;
            ReadFile file_reader = new ReadFile(path);
            return file_reader;
        }

        private static Trie getTrie()
        {
            Trie dt = new Trie();
            return dt;
        }

    }
}
