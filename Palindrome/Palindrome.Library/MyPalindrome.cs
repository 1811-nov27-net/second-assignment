using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome.Library
{
    public class MyPalindrome
    {
        private readonly List<char> _list = new List<char>();

        public void Add(char item)
        {
            _list.Add(item);
        }

        // only checks to see if reverse string is equal to original string, does nothing
        // about the issue of whitespaces in a string
        public bool PalindromeCheck(string statement)
        {
            return statement.SequenceEqual(statement.Reverse());
        }
    }
}
