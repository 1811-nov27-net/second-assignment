using PalindromeLibrary.library;
using System;
using Xunit;

namespace PalindromeTesting.test
{
    public class PalindromeTests
    {
        // Reads the same forwards and backwards

        [Theory]
        // Valid palindromes
        [InlineData(true, 
                    "nurses run",
                    "racecaR",
                    "1221",
                    "never odd, or even.")]
        // Invalid palindromes
        [InlineData(false,
                    "one two one", 
                    "123abccba123")]
        public void StringIsAPalindrome(bool expected, params string[] inputString)
        {
            // Arrange
            // Data is already arranged through inline data

            // Act
            foreach (string s in inputString)
            {
                bool actual = Palindrome.IsPalindrome(s);
                // Asserting in the foreach loop since I want
                //  to test each string provided through
                //  InlineData
                Assert.True(expected == actual);
            }

            // Assert

        }
    }
}
