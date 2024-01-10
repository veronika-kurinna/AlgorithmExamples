using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.AlgorithmsTests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("madam")]
        [InlineData("anna")]
        [InlineData("smart trams")]
        [InlineData("radar")]
        [InlineData("k")]
        public void IsPalindrome_WordIsPalindrome_ReturnsTrue(string word)
        {
            //Arrange && Act
            bool result = Palindrome.IsPalindrome(word);

            //Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("madvm")]
        [InlineData("mvdam")]
        [InlineData("cat")]
        public void IsPalindrome_WordIsNotPalindrome_ReturnsFalse(string word)
        {
            //Arrange && Act
            bool result = Palindrome.IsPalindrome(word);

            //Assert
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void IsPalindrome_WordIsInvalid_ThrowsArgumentException(string word)
        {
            //Arrange && Act && Assert
            Action action = () => Palindrome.IsPalindrome(word);
            action.Should().Throw<ArgumentException>()
                            .WithMessage("Word is invalid. Word must have letters");
        }
    }
}
