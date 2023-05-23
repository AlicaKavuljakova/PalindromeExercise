using PalindromeExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeExerciseTests
{
    public class WordSmithTest
    {
        [Theory]
        [InlineData("potato", false)]
        [InlineData("", false)]

        [InlineData("Kayak", true)]

        [InlineData("level", true)]

        [InlineData("bob", true)]

        [InlineData("deed", true)]
        [InlineData(null,false)]
        void isPalindromeTest(string word, bool expected)
        {
            var test = new WordSmith();
            var actual = test.isPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
