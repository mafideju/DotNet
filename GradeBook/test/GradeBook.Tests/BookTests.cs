using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void SimpleSum()
        {
            int x = 1;
            int y = 2;
            int expect = 3;

            int actual = x + y;
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void ShowBookStats()
        {
            var book = new Book("");
            book.AddGrade(10.11);
            book.AddGrade(89.89);

            var stats = book.showStats();

            Assert.Equal(89.89, stats.High);
            Assert.Equal(10.11, stats.Low);
            Assert.Equal(50, stats.Average);
        }
    }
}
