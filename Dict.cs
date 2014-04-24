using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BookParser_hash
{
    class Dict
    {
        private Dictionary<string, int> dict;

        public Dict()
        {
            dict = new Dictionary<string, int>();
        }

        public int add(string key)
        {
            if (dict.ContainsKey(key))
            {
                dict[key]++;
            }
            else
            {
                dict.Add(key, 1);
            }
            return dict[key];
        }

        public Dictionary<string, int> getDictionary()
        {
            return dict;
        }

    }
}
