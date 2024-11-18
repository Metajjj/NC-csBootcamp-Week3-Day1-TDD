using System.Drawing;

using Compass;

namespace Compass.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //Setup prior to tests
        }

        
        public enum Points
        {
            North, East, South, West
        }
        public enum Directions
        {
            Left, Right
        }


        [Test]
        public void Test1()
        {
            //var compass = new Compass();


            //Setup vals
            var p = Points.North;
            var dir = Directions.Right;

            //Cal func
            var result = new Compass()

            //Check res


            Assert.Pass();
        }
    }
}