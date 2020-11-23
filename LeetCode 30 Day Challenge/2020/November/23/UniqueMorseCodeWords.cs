using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_30_Day_Challenge
{
    class UniqueMorseCodeWords
    {
        // https://leetcode.com/explore/challenge/card/november-leetcoding-challenge/567/week-4-november-22nd-november-28th/3540/
        // Accepted
        static void UniqueMorseCodeWordsMain(string[] args)
        {
            string[] words = { "gin", "zen", "gig", "msg" };
            int uniqueMorseCodeRepresentations = UniqueMorseRepresentations(words);
            Console.ReadKey();
        }

        public static int UniqueMorseRepresentations(string[] words)
        {
            string[] morseCodes = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            Dictionary<string, int> morseCodeRepresentations = new Dictionary<string, int>();
            foreach (string word in words)
            {
                StringBuilder wordMorseCode = new StringBuilder();
                foreach (char letter in word)
                {
                    string letterMorseCode = morseCodes[(int)letter - 97];
                    wordMorseCode.Append(letterMorseCode);
                }
                if (morseCodeRepresentations.ContainsKey(wordMorseCode.ToString()))
                {
                    morseCodeRepresentations[wordMorseCode.ToString()] = morseCodeRepresentations[wordMorseCode.ToString()] + 1;
                }
                else
                {
                    morseCodeRepresentations.Add(wordMorseCode.ToString(), 1);
                }

            }
            return morseCodeRepresentations.Count;
        }
    }
}
