using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("madam")]
        [InlineData("anna")]
        [InlineData("smart trams")]
        [InlineData("radar")]
        [InlineData("k")]
        public void IsWordPalindrome_WordIsPalindrome_ReturnsTrue(string word)
        {
            //Arrange
            Palindrome palindrome = new Palindrome();

            //Act
            bool result = palindrome.IsWordPalindrome(word);

            //Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("madvm")]
        [InlineData("mvdam")]
        [InlineData("cat")]
        public void IsWordPalindrome_WordIsNotPalindrome_ReturnsFalse(string word)
        {
            //Arrange
            Palindrome palindrome = new Palindrome();

            //Act
            bool result = palindrome.IsWordPalindrome(word);

            //Assert
            result.Should().BeFalse();
        }
    }
}
