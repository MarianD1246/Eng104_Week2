using NUnit.Framework;
using ExceptionsApp;
using ExceptionApp;
using System;

namespace ExceptionsTests
{
    public class GradeTests
    {
        [TestCase(-34)]
        [TestCase(-1)]
        [TestCase(101)]
        [TestCase(10.5)]
        public void WhenMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>());
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<GradeException>());

        }
    }
}