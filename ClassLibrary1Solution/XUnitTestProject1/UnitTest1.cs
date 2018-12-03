using ClassLibrary1;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// test if pallindromes are correctly identified
        /// </summary>
        /// <param name="s">string to identify as Pallindrome/Nonpallindrome</param>
        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even")]
        public void PallindromesReturnTrue(string s)
        {
            // set up sut and give it a string
            Class1 sut = new Class1(s);
            //call IsPallindrome()
            bool actual = sut.IsPallindrome();
            //check that IsPallindrome returned true
            Assert.True(actual);
        }
        /// <summary>
        /// test whether non pallindromes are identitfied correctly.
        /// </summary>
        /// <param name="s">string to identify as Pallindrome/Nonpallindrome</param>
        [Theory]
        [InlineData("one two one")]
        [InlineData("123abccba123")]
        public void NonPallindromesReturnFalse(string s)
        {
            //Instantiate sut and give it a string
            Class1 sut = new Class1(s);
            //Call IsPallindrome
            bool actual = sut.IsPallindrome();
            //check that IsPallindrome returned false
            Assert.False(actual);
        }
    }
}
