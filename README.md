# Trie data structure #

Thanks to scripting languages, now we use Hashes as granted. Hashes are very useful but it is important to know the purpose and the area of usage.

### Lets code a book parser: ### 

Branch : [master](https://bitbucket.org/ppasupula/coding-a-trie-book-parsing-algorithm/branch/hash_table)

In our case we could do better things if we could use a data structure suitable for parsing. First thing comes to mind is awesome BST. But with our data tree becomes very imbalanced and depth could increase easily. Also thought of using 26 BSTs where each root is a character (ignoring numbers and special chars). Though look-ups are faster, this could work well but it still has implementation complexity and insertions and deletions of words can be expensive.

In the end, I used Tries. This a very simple data structure. look-up, insertions and deletions have almost same time complexity.

### Advantages: ###

1. simple data structure
2. look-up, insertions and deletions have almost linier complexity.
3. Ordered/ sorted
4. Suitable for predictions, prefix searching.
5. O(length of the word)

### Disadvantages: ###

1. Could be slower if compared with hash table O(1)
2. If length of words are big you get bigger look-up time. (In our case it is a book and you can't make up words ;)
3. Not suitable for very random data.

------------------------------------------------

### Using hash table: ###

Branch : [hash_table](https://bitbucket.org/ppasupula/coding-a-trie-book-parsing-algorithm/branch/master)

### Advantages: ###

1. Easy to implement.
2. Usually gives good performance.
3. O(1) look-up time. In our case/usually we don't expect collisions.

### Disadvantages: ###

1. More memory used (cat and cattle are stored independently) and hash tables usually uses more space.
2. Cannot find if a string exist unless you know it or go through all its keys.
3. To do tasks like finding prefixes, predictions can become memory and cpu intensive operations.
4. Not sorted
5. Synchronized (Only one thread can access at a time)
6. Performance depends on distribution (randomness of data)
7. as usual insertions and deletions need rebuilding indexes.