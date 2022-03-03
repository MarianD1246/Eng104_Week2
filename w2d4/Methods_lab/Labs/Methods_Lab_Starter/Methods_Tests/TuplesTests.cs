using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks"); //if it were to fail the weeks message would apear
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [TestCase(0 ,0, 0, 0)]
        [TestCase(1, 1, 1, 1)]
        [TestCase(2, 4, 8, 1.4142135623730951)]
        [TestCase(9, 81, 729, 3)]
        [TestCase(24, 576, 13824, 4.898979485566356)]
        [TestCase(-12, 144, -1728, double.NaN)]
        [TestCase(154, 23716, 3652264, 12.409673645990857)]
        public void GivenANumerTo_PowerRoot_ReturnCorrectTuple(
            int nrToRoot, int squareExp, int cubeExp, double rootExp)
        {
            var answer = Methods.PowersRoot(nrToRoot);
            var expected = (square: squareExp, cube: cubeExp, root: rootExp);
            Assert.That(answer, Is.EqualTo(expected));
        }

        [TestCase(1,3)]
        [TestCase(5,5)]
        [TestCase(6,10)]
        [TestCase(60,4)]
        //[Repeat(x)] repteats test above x amount of times.
        public void GiveSeedTo_RollDice_ReturnExpectedDiceResult(int seed, int result)
        {
            var answer = Methods.RollDice(new Random(seed));
            Assert.That(answer, Is.EqualTo(result));
        }
    }
}