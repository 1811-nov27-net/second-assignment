using Palindrone.Library;
using Xunit;


namespace PalindroneUnitTest
{
    public class PalindroneUnitTest
    {
        [Theory]
        [InlineData("nurses run", true)]
        [InlineData("racecaR", true)]
        [InlineData("1221", true)]
        [InlineData("never odd or even", true)]
        [InlineData("one two one", false)]
        [InlineData("123abccba123", false)]
        public void CheckForPalindrone(string palindrone, bool expectation)
        {
            var pal = new PalindroneClass(palindrone);

            bool check = pal.checkPalindrone();

            Assert.Equal(expectation, check);
            

        }
    }
}


