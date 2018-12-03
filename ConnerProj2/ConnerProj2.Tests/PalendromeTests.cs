using ConnerProj2.Library;
using System;
using Xunit;

namespace ConnerProj2.Tests
{
    public class PalendromeTests
    {
        [Fact]
        public void TestEmptyPalendrome()
        {
            //PalendromeFinder pf = new PalendromeFinder();

            bool result = PalendromeFinder.findPalendrome("");

            Assert.True(result);
        }

        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even.")]
        public void TestTruePalendromes(string s)
        {
            //PalendromeFinder pf = new PalendromeFinder();

            bool result = PalendromeFinder.findPalendrome(s);

            Assert.True(result);
        }

        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void TestFalsePalendromes(string s)
        {
            //PalendromeFinder pf = new PalendromeFinder();

            bool result = PalendromeFinder.findPalendrome(s);

            Assert.False(result);
        }


    }
}
