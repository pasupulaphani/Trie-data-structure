using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace BookParser_hash
{
    class ReadFile
    {
        private string file_loc;

        public ReadFile(string file_loc)
        {
            this.file_loc = file_loc;
        }

        public IEnumerable<string> getWord()
        {
            string line;
            StreamReader sr = new StreamReader(file_loc);

            while ((line = sr.ReadLine()) != null)
            {
                foreach (var word in GetWords(line))
                {
                    yield return word;
                }
            }

        }

        public static string[] GetWords(string input)
        {
            MatchCollection matches = Regex.Matches(input, @"\b[\w']*\b");

            var words = from m in matches.Cast<Match>()
                        where !string.IsNullOrEmpty(m.Value)
                        select TrimSuffix(m.Value).ToLower();

            return words.ToArray();
        }

        public static string TrimSuffix(string word)
        {
            int apostropheLocation = word.IndexOf('\'');
            if (apostropheLocation != -1)
            {
                word = word.Substring(0, apostropheLocation);
            }

            return word;
        }
    }
}
