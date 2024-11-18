using FluentAssertions;
using TDD;

namespace TDD.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(TestName = "Rotate_NothToRight_ReturnsEast" )]
        public void Rotate_NothToRight_ReturnsEast()
        {
            var compass = new Compass();

            //Setup vals
            var p = Compass.Points.North;
            var dir = Compass.Directions.Right;

            //Cal func
            var result = compass.Rotate(p, dir);

            //Check res
            //Assert.That(result==Compass.Points.East);
            result.Should().Be(Compass.Points.East);



            //Assert.Pass();
        }
    }
}