using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalClient
{
    class Coordinate
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return string.Format("({0, 3}, {1, 3})", X, Y);
        }

        public override bool Equals(Object obj)
        {
            Coordinate coordinate = (Coordinate)obj;
            if((X == coordinate.X) && (Y == coordinate.Y)) { return true; }
            return false; 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
