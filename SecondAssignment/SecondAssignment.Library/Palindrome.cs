using System;
using System.Collections.Generic;

namespace SecondAssignment.Library
{
    public class Palindrome
    {
        public string text { get; set; }

        public bool PCheck(string p)
        {
            string onlyLetters = null;

            foreach(char c in p)
            {
                if(Char.IsLetter(c))
                {
                    String.Concat(onlyLetters, c);
                }
            }

            if(onlyLetters.ToUpper().EndsWith(onlyLetters.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
