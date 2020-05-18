using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_30_Day_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Trie obj = new Trie();
            obj.Insert("apple");
            bool param_2 = obj.Search("app");
            bool param_3 = obj.StartsWith("app");

        }
    }

    public class Trie
    {
        static readonly int ALPHABET_SIZE = 26;
        public class TrieNode
        {
            public TrieNode[] Children = new TrieNode[ALPHABET_SIZE];
            public bool IsEndOfWord { get; set; }
            public TrieNode()
            {
                IsEndOfWord = false;
                for (int i = 0; i < ALPHABET_SIZE; i++)
                    Children[i] = null;
            }
        }

        static TrieNode root = new TrieNode();
        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode parent = root;
            for (int i = 0; i < word.Length; i++)
            {
                int childIndex = word[i] - 'a';
                if (parent.Children[childIndex] == null)
                    parent.Children[childIndex] = new TrieNode();
                parent = parent.Children[childIndex];
            }
            parent.IsEndOfWord = true;
        }
        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            throw new NotImplementedException();
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            throw new NotImplementedException();
        }
    }
}
