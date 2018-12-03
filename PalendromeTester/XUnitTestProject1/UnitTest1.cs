using PalendromeTester;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]

        [InlineData("nurses run", true)]
        [InlineData("racecaR", true)]
        [InlineData("1221", true)]
        [InlineData("never odd, or even.", true)]
        [InlineData("one two one", false)]
        [InlineData("123abccba123", false)]

        public void PalendromeTesterTests(string testString, bool expected)
        {
            PT SUT = new PT();
            bool result = SUT.isPalendrome(testString);
            Assert.Equal(expected, result);
        }
    }
}
