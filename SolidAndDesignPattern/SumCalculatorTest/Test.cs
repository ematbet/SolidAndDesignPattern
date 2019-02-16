using NUnit.Framework;
using SolidAndDesignPattern.Liskov.SumCalculator;
using System;
namespace SumCalculatorTest
{
    [TestFixture()]
    public class Test
    {
        [Test]
        public void TestCase()
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            Calculator sum = new SumCalculator(numbers);
            Assert.AreEqual(sum.Calculate(), 40);

            EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Assert.AreEqual(evenSum.Calculate(), 18);
        }

        [Test]
        public void ShouldReturn18b()
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            Calculator sum = new EvenNumbersSumCalculator(numbers);
            Assert.AreEqual(sum.Calculate(), 18);


        }
    }
}
