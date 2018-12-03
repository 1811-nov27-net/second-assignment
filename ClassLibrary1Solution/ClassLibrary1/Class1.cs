using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Class1
    {
        string s;
        
        /// <summary>
        /// constructor that takes a string argument
        /// </summary>
        /// <param name="arg">string that will be identified as a pallidrome or not</param>
        public Class1(string arg)
        {
            s = arg;
        }
        /// <summary>
        /// Method to determine whether the string s is a pallindrome or not
        /// </summary>
        /// <returns></returns>
        public bool IsPallindrome()
        {
            List<char> temp = new List<char>();
            //remove white spaces and special characters, and convert all letters to lower case
            foreach (char c in s.ToLower())
            {
                if ("abcdefghijklmnopqrstuvwxyz1234567890".Contains(c))
                    temp.Add(c);
            }
            //determine if the string is a pallindrome
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] != temp[(temp.Count - 1) - i])
                    return false;
            }
            return true;
        }
    }
}
