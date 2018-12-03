using PalindromeClass.Library;
using System;
using Xunit;

namespace Palindrome.Tests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("nurses run", true)]
        [InlineData("racecaR", true)]
        [InlineData("1221", true)]
        [InlineData("never odd, or even", true)]
        [InlineData("one two one", false)]
        [InlineData("123abccba123", false)]
        public void CheckIfPalindrome(string input, bool expected)
        {
            var pal = new PalindromeClass(input);
            bool isPal = pal.IsPalindrome();

            Assert.Equal(expected, isPal);

        }
    }
}
