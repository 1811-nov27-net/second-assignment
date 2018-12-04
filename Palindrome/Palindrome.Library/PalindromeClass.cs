using System;

namespace Palindrome.Library
{
    public class PalindromeClass
    {
        public string word;

        public PalindromeClass(string inputP)
        {
            word = inputP;
        }

        public bool IsPalindrome()
        {
            word = word.Replace(" ", "");
            word = word.Replace(",", "");
            word = word.Replace(".", "");
            word = word.Replace("!", "");
            word = word.Replace("?", "");
            word = word.Replace(";", "");
            word = word.ToLower();

            string first = word.Substring(0, word.Length / 2);
            char[] arr = word.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
