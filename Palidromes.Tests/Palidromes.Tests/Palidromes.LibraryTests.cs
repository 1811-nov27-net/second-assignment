using System;
using Xunit;
using Palidromes.Palidromes.Library;

namespace Palidromes.Tests
{
    public class PalidromesLibraryTests
    {
        [Thoery]
        [InlineData(new string[] {"nurses run", "racecaR", "1221",})]

        public void Test1(string[] paltests, string expected )
        {
             // arrange
            var coll = new Program();
            Program.Is
        
            // act
            string actual = true;

            // assert
            Assert.Equal(expected, actual);
        }
    }
}

all the behavior of the class should be unit tested.

a palindrome reads the same forwards and backwards.

these should be considered palindromes:

    "nurses run"

    "racecaR"

    "1221"

    "never odd, or even"

these should not be considered palindromes:

    "one two one"

    "123abccba123"```