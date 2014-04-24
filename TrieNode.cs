using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookParser_Trie
{
    class TrieNode
    {
        private char character;
        private TrieNode parent_node;
        public int word_count;
        private Dictionary<char, TrieNode> edges;

        public TrieNode(char character, TrieNode parent_node)
        {
            this.character = character;
            this.parent_node = parent_node;
            this.word_count = 0;
            this.edges = new Dictionary<char,TrieNode>();
        }

        public TrieNode add(char character)
        {
            TrieNode edge;
            if (edges.ContainsKey(character))
            {
                edge = edges[character];
            }
            else
            {
                TrieNode new_edge = new TrieNode(character, this);
                edges.Add(character, new_edge);
                edge = new_edge;
            }
            return edge;
        }

        public void addWordCountToDictionary(ref Dictionary<string, int> dt)
        {
            foreach (var edge in this.edges)
            {
                if (edge.Value.word_count > 0)
                {
                    dt.Add(edge.Value.getWord(), edge.Value.word_count);
                }
                else
                {
                    edge.Value.addWordCountToDictionary(ref dt);
                }
            }
        }

        public string getWord()
        {
            if (this.parent_node == null)
            {
                return "";
            }
            else
            {
                return this.parent_node.getWord() + this.character;
            }

        }
    }
}
