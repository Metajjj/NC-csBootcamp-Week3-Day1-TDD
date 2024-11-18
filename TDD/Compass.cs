using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Compass
    {

        public enum Points
        {
            North, East, South, West
        }
        public enum Directions
        {
            Left, Right
        }

        Points point;

        public Points Rotate(Points point, Directions direction)
        {
            return Points.South;
        }
    }
}
