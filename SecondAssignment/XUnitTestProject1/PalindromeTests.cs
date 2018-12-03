using SecondAssignment.Library;
using System;
using Xunit;

namespace SecondAssignment.Tests
{
    public class PalindromeTests
    {
        [Theory]
        public void StringIsAPalindrome(string item, bool expected)
        {
            // Arrange
            var palin = new Palindrome();

            // Act
            bool result = palin.PCheck(item);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
