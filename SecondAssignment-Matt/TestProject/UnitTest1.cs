using System;
using Xunit;
using SecondAssignment;

namespace SecondAssignment
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even")]

        public void ShouldReturnTrue(string item)
        {
            var palCheck = new PalChecker();

            var result = palCheck.checker(item);

            Assert.True(result, $"{item} is a palindrome");

        }
    }
}
