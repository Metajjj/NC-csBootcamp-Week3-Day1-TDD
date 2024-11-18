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
            int i = (direction == Directions.Right) ? (int)direction : -1;
            //Works - now to add to Points enum

            Points newPoint = point + i ;
            if ( (int)newPoint > 3) { newPoint = (Points)0; }
            else if ( (int)newPoint < 0) { newPoint = (Points)3; }


            return newPoint;

            /*if (direction == Directions.Right && point == Points.North)
            {
                return Points.East;
            }
            return Points.South;*/
        }
    }
}
