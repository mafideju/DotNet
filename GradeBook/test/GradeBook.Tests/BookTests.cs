using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            int x = 1;
            int y = 2;
            int expect = 3;

            int actual = x + y;
            Assert.Equal(expect, actual);
        }
    }
}
