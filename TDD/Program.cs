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
            var compass = new Compass();

            var p = Compass.Points.North;
            var dir = Compass.Directions.Left;

            //var result = compass.Rotate(p, dir);
        }

        public enum Points
        {
            North, East, South, West
        }
        public enum Directions
        {
            Left, Right
        }



    }
}
