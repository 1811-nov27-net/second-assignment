using System;

namespace PalindromeLibrary.library
{
    public static class Palindrome
    {

        public static bool IsPalindrome(string inputString)
        {
            // Compare the front to the end
            //  moving inward towards the center
            //  of the string.
            int frontIndex = 0;
            int endIndex = inputString.Length - 1;
            
            for (int i = 0; i < inputString.Length / 2; i++)
            {
                // For a string to be a palindrome it should
                //  be symetrical
                if (inputString[frontIndex] != inputString[endIndex])
                    return false;
            }

            // The front half of the string matched
            //  the back half, it is a palindrome.
            return true;

        }

    }
}
