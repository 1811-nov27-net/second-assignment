using System;
using Xunit;
using Palindrome.Library;

namespace PalindromeTest
{
    public class PalindromeTest
    {
        [Theory]
        [InlineData("nurses run", true)]
        [InlineData("racecaR", true)]
        [InlineData("1221", true)]
        [InlineData("never odd, or even.", true)]
        [InlineData("one two one", false)]
        [InlineData("123abccba123", false)]
        public void TestPalindrome(string sentence, bool expected)
        {
            // act
            bool result = PalindromeClass.isPalindrome(sentence);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
