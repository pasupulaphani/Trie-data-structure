using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BookParser_Trie
{
    class Trie
    {
        private TrieNode root_node;

        public Trie()
        {
            this.root_node = new TrieNode(' ', null);
        }

        // this returns the count. Not used ATM but useful in if you want to extend trie to BFS
        public int add(string word)
        {
            TrieNode start_node = this.root_node;

            foreach (char c in word.ToCharArray())
            {
                start_node = start_node.add(c);
            }
            return ++start_node.word_count;
        }

        public Dictionary<string, int> getDictionary()
        {
            Dictionary<string, int> dt = new Dictionary<string, int>();

            this.root_node.addWordCountToDictionary(ref dt);

            return dt;
        }
    }
}
