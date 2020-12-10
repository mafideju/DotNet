using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void InstanceTwoVariablesFromSameObject()
        {
            var book1 = GetBook("Book One");
            var book2 = GetBook("Book Two");

            Assert.Equal("Book One", book1._name);
            Assert.Equal("Book Two", book2._name);
        }

        [Fact]
        public void ChangeBookName() 
        {
            var book1 = GetBook("Book One");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1._name);
            Assert.NotSame(book1._name, "Book One");
        }

        private void SetName(Book book, string name)
        {
            book._name = name;
        }

        internal Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
