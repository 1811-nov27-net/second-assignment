using System;

namespace Palindrone.Library
{
    public class PalindroneClass
    {
        public string palindroneWord;

        public PalindroneClass(string input)
        {
            // assigns the input from the testing class to the private variable in the library
            palindroneWord = input;
        }

        public bool checkPalindrone()
        {
            // this method will check to see if the string that has been assigned to the private variable is
            // a palindrone


            // stores the string into a charactar array for the purpose of separating all the characters
            char[] charPalindrone = palindroneWord.ToCharArray();

            string firstHalf = palindroneWord.Substring(0, palindroneWord.Length / 2);

            Array.Reverse(charPalindrone);

            string temp = new string(charPalindrone);

            string secondHalf = temp.Substring(0, temp.Length / 2);

            return firstHalf.Equals(secondHalf);


        }

    }
}
