using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookParser_hash
{
    class WordCount
    {
        ReadFile file_reader;
        Dict dt;

        public WordCount(ReadFile file_reader, Dict dt)
        {
            this.file_reader = file_reader;
            this.dt = dt;
        }

        public void count()
        {
            foreach (var word in file_reader.getWord())
            {
                dt.add(word);
            }
        }

        public Dictionary<string, int> getDict()
        {
            return dt.getDictionary();
        }
    }
}
