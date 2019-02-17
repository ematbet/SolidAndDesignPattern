using NUnit.Framework;
using SolidAndDesignPattern.Liskov.Shape;
using System;
namespace RectangleTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestWithRectangle()
        {
            Rectangle sut = new Rectangle();
            sut.Heigth = 3;
            sut.Width = 7;
            Assert.AreEqual(21, sut.Area());
        }

        [Test]
        public void TestWithSquare()
        {
            Shape sut = new Square();
            //sut.Heigth = 3;
            //sut.Width = 7;
            Assert.AreEqual(21, sut.Area()); //This test will fail. Area equals 49.
        }
    }
}
