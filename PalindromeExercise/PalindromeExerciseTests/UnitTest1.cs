using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("Jesse", false)]
        public void IsPalindromeTest(string word, bool expected)
        {
            //Arrange
            var instance = new WordSmith();

            //Act
            var actual = instance.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
