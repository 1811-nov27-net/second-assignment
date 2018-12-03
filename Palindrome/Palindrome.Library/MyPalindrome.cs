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

        /*
        public bool PalindromeCheck()
        {

        }
        */

        public bool PalindromeCheck(string statement)
        {
            return statement.SequenceEqual(statement.Reverse());
        }
    }
}
