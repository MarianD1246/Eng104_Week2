using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        // Num1 // factor // isfactor
        [Category("Every number is a factor of 0!")]
        [TestCase(0, 1, true)]
        [TestCase(0, -1, true)]
        [TestCase(0, 12, true)]
        [TestCase(0, -12, true)]
        [TestCase(0, 1992992, true)]
        [TestCase(0, -1992992, true)]

        [Category("Who are the factors of 6")] //1,2,3,6
        [TestCase(6, 2, true)]
        [TestCase(6, -2, true)]
        [TestCase(6, 3, true)]
        [TestCase(6, -3, true)]
        [TestCase(6, 4, false)]
        [TestCase(6, -4, false)]
        //[TestCase(2, 0, false)] //div by 0 error
        public void IsNum2FactorOfNum2_MyMethod_ReturnsCorrectAverage(int a, int b, bool expected)
        {
            Assert.That(Exercises.MyMethod(a,b), Is.EqualTo(expected));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }


        [Category("Out of bounds")]
        [TestCase(101, "Parameter out of bounds")]
        [TestCase(-1, "Parameter out of bounds")]

        [Category("Edge Case")]
        [TestCase(100, "Pass with Distinction")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(59, "Pass")]
        [TestCase(40, "Pass")]
        [TestCase(39, "Fail")]
        [TestCase(0, "Fail")]

        [Category("Safe Case")]
        [TestCase(85, "Pass with Distinction")]
        [TestCase(70, "Pass with Merit")]
        [TestCase(50, "Pass")]
        [TestCase(25, "Fail")]
        public void GradeTest(int grade, string expected)
        {
            Assert.That(expected, Is.EqualTo(Exercises.Grade(grade)));
        }
    }
}
