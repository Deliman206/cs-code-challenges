using System;
using Xunit;
using CodeChallenges;

namespace CodingChallenges
{
    public class Do
    {
        int[] sortedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [Fact]
        public void ValueDoesNotExistInArray()
        {
            Assert.Equal(-1, Program._BinarySearch(sortedArray, 11));
        }
        [Fact]
        public void ValueDoesExistInArray()
        {
            Assert.Equal(1, Program._BinarySearch(sortedArray, 1));
        }
    }
}
