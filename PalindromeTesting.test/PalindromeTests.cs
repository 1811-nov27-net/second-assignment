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
        [InlineData(true, "aabaa")]
        [InlineData(true, "nurses run")]
        [InlineData(true, "racecaR")]
        [InlineData(true, "1221")]
        [InlineData(true, "never odd, or even.")]

        // Invalid palindromes
        [InlineData(false, "one two one")]
        [InlineData(false, "123abccba123")]
        [InlineData(false, "")]
        [InlineData(false, null)]
        public void StringIsAPalindrome(bool expected, string inputString)
        {
            // Arrange
            // Data is already arranged through inline data

            // Act
            bool actual = Palindrome.IsPalindrome(inputString);
            
            // Assert
            Assert.True(expected == actual);


        }
    }
}
