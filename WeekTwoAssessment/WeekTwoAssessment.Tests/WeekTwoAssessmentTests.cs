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
        [InlineData( new string "noon", true)]
        [InlineData(new string "101", true)]
        [InlineData(new string "Beau", false]
        [InlineData(new string "1334", false]

        static void PalindromeCheckForVariousArguments(string item, string expected)
        {
            // arrange
            Word sut = new Word();

            // act
            actual = sut.CheckPalindrome();

            // assert
            Assert.Equal(expected, actual)
        }


    }
}
