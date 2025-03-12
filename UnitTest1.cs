using System.Numerics;

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
            //assert
            Assert.AreEqual(5, result);
        }
    }
}