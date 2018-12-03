using Palindrome.Library;
using System;
using Xunit;

namespace Palindrome.Test
{
    public class PalindromeTest 
    {
        /// <summary>
        /// Purpose is to check to see if input statement is a palindrome
        /// </summary>

        [Theory]
        [InlineData("nurses run", true)]
        [InlineData("racecar", true)]
        public void CheckIfPalindromeOrNot(string phrase, bool expected)
        {
            // arrange
            var sut = new MyPalindrome();
            foreach (var item in phrase)
            {
                sut.Add(item);
            }

            // act
            bool actual = sut.PalindromeCheck(phrase);

            // assert
            Assert.Equal(expected, actual);

        }
    }
}
