using NUnit.Framework;
using CA1;

namespace ModTestProject1
{
    public class StoneTests
    {

        [TestCase(2, true)]
        [TestCase(1, false)]
        [TestCase(30, true)]
        [TestCase(15, false)]
        public void TestMod_EvenOff(int num, bool expected)
        {
            Assert.That(expected, Is.EqualTo(Program.EvenOff(num)));
        }

        [TestCase(5, 8)]
        [TestCase(10, 33)]
        [TestCase(13, 45)]
        [TestCase(20, 98)]
        public void TestMod_FinSumDiv3and5(int num, int expected)
        {
            Assert.That(expected, Is.EqualTo(Program.FinSumDiv3and5(num)));
        }

        [TestCase(-14, 0)]
        [TestCase(-1, 0)]
        [TestCase(-0, 0)]
        [TestCase(13, 0)]
        [TestCase(14, 1)]
        [TestCase(20, 1)]
        [TestCase(58, 4)]
        public void TestMod_GetStones(int num, int expected)
        {
            Assert.That(expected, Is.EqualTo(Method.GetStones(num)));
        }

        [TestCase(-13, 0)]
        [TestCase(-1, 0)]
        [TestCase(0, 0)]
        [TestCase(13, 13)]
        [TestCase(14, 0)]
        [TestCase(20, 6)]
        [TestCase(58, 2)]
        public void TestMod_GetPounds(int num, int expected)
        {
            Assert.That(expected, Is.EqualTo(Method.GetPounds(num)));
        }

    }
}