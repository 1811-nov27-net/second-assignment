using System;
using System.Linq;

namespace PalindromeLibrary.library
{
    public static class Palindrome
    {

        public static bool IsPalindrome(string inputString)
        {
            // Make sure the string we get is valid.
            if (inputString == null || inputString.Length == 0)
                return false;

            // Not checking for case sensitivity, 
            //  comapare lowercase string versions
            string lowerString = inputString.ToLower();
            // TODO: Fix; currently not working 
            // Use LINQ to remove non letters / digits
            //lowerString = lowerString.Where(i =>
            //{
            //    return char.IsLetterOrDigit(i);
            //}
            //)
            //.ToString();

            // Compare the front to the end
            //  moving inward towards the center
            //  of the string.
            int frontIndex = 0;
            int endIndex = lowerString.Length - 1;
            
            for (int i = 0; i < lowerString.Length / 2; i++)
            {
                // For a string to be a palindrome it should
                //  be symetrical
                if (lowerString[frontIndex] != lowerString[endIndex])
                    return false;
            }

            // The front half of the string matched
            //  the back half, it is a palindrome.
            return true;

        }

    }
}
