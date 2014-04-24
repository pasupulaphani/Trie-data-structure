using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace BookParser_Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file location to read");
            //string file_loc = "C:\\Users\\IEUser\\Downloads\\test.txt";
            string file_loc = Console.ReadLine();

            if (File.Exists(file_loc))
            {
                ParseFile(file_loc);
            }
            else
            {
                Console.WriteLine("File not found");
            }
            Console.ReadLine();
        }

        public static void ParseFile(string file_loc)
        {
            ReadFile file_reader = new ReadFile(file_loc);
            Trie trie = new Trie();
            WordCount word_counter = new WordCount(file_reader, trie);
            word_counter.count();

            Console.WriteLine("Count : isPrime  :  Word");
            foreach (var entry in word_counter.getDict())
            {
                Console.WriteLine(entry.Value + "     : " + isPrime(entry.Value) + "  :  " + entry.Key);
            }
        }

        public static bool isPrime(int number)
        {
            if (number < 0) throw new System.ArgumentException("Parameter cannot be negative");
            int boundary = (int)Math.Sqrt(number);

            if (number == 1 || number == 0) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
