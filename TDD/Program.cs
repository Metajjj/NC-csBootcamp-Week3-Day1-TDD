namespace TDD
{
    internal class Program
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
    }
}
