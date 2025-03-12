using System.Numerics;
using NUnit.Framework;

namespace TheCalculatorProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldAdd()
        {
            //arrange
            var systemUnderTest = new Addition();
            //act
            var result = systemUnderTest.Add(2, 3);
            //assert2
            Assert.AreEqual(5, result);
        }
    }
}