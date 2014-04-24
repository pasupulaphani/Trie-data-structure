using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BookParser_hash.tests
{
    [TestFixture]
    class TestReadFile
    {
        [Test]
        public void TestReadFilewithWordsinColons()
        {
            List<String> actual = new List<String>();
            List<String> expected = new List<String>();

            // this is not the proper way but I couldn't findhow to find a file
            string path = Environment.CurrentDirectory + "/../../tests/word1count1.txt";
            ReadFile file_reader = new ReadFile(path);
            foreach (string word in file_reader.getWord())
            {
                actual.Add(word);
            }
            expected.Add("word1");
            expected.Add("word2");

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestReadFilewithmorePunctuation()
        {
            List<String> actual = new List<String>();
            List<String> expected = new List<String>();

            // this is not the proper way but I couldn't findhow to find a file
            string path = Environment.CurrentDirectory + "/../../tests/word1count2.txt";
            ReadFile file_reader = new ReadFile(path);
            foreach (string word in file_reader.getWord())
            {
                actual.Add(word);
            }
            expected.Add("word1");
            expected.Add("word2");
            expected.Add("word1");

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestGetWordswithWordsinColons()
        {
            string[] actual = ReadFile.GetWords("word1:word2");
            string[] expected = {"word1", "word2"};

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestGetWordswithmorePunctuation()
        {
            string[] actual = ReadFile.GetWords("word1 word2+word1,:*;");
            string[] expected = { "word1", "word2", "word1" };

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestTrimSuffix()
        {
            string actual = ReadFile.TrimSuffix("aren\'t");
            string expected = "aren";

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }

        [Test]
        public void TestTrimSuffixUnicode()
        {
            string actual = ReadFile.TrimSuffix("aren\u0027t");
            string expected = "aren";

            Assert.AreEqual(expected, actual,
                "expected :" + expected + " did not match actual :" + actual);
        }
    }
}
