namespace TDD
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            
                //Avoid static vs non static
            new Program().Main();
            Console.ReadKey();
        }
        void Main()
        {

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

            var compass = new TDD.Compass();

            //Setup vals
            var p = compass.Points.North;
            var dir = compass.Directions.Right;

            //Cal func
            var result = compass.Rotate(p, dir);

            //Check res
            Assert.That(result.Should().Be(compass.Points.East));



            //Assert.Pass();
        }
    }
}
