using System;
using Xunit;
using WeekTwoAssessment.Library;


namespace WeekTwoAssessment
{
    public class WeekTwoAssessmentTests
    {
        [Fact]
        static void InstanceIsNotEmpty()
        {
            // arrange
            Word sut = new Word();

            // act
            result = sut.name;

            // assert
            Assert.NotEqual(null, result);
        }

        [Theory]
        [InlineData("noon", true)]
        [InlineData("101", true)]
        [InlineData("Beau", false)]
        [InlineData("1334", false)]

        static void PalindromeCheckForVariousArguments(string item, bool expected)
        {
            // arrange
            Word sut = new Word();

            // act
            actual = sut.checkPalindrome();

            // assert
            Assert.Equal(expected, actual);
        }


    }
}
