using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookParser_Trie
{
    class WordCount
    {
        ReadFile file_reader;
        Trie trie;

        public WordCount(ReadFile file_reader, Trie trie)
        {
            this.file_reader = file_reader;
            this.trie = trie;
        }

        public void count()
        {
            foreach (var word in file_reader.getWord())
            {
                trie.add(word);
            }
        }

        public Dictionary<string, int> getDict()
        {
            return trie.getDictionary();
            //return this.dt;
        }
    }
}
