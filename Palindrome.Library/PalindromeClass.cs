using System;

namespace Palindrome.Library
{
    public class PalindromeClass
    {
        public static bool isPalindrome(string sentence)
        {
            sentence = sentence.ToLower();
            sentence = sentence.Replace(" ", "");
            sentence = sentence.Replace(",", "");
            sentence = sentence.Replace(".", "");
            sentence = sentence.Replace("!", "");
            sentence = sentence.Replace("?", "");
            
            int length = sentence.Length;
            char[] reversed = new char[length];
            string reversedString = "";

            for (int i=0; i<length; i++)
            {
                reversed[i] = sentence[length-i-1];
            }

            reversedString = new string(reversed);

            if (sentence == reversedString)
                return true;

            return false;
        }
    }
}
