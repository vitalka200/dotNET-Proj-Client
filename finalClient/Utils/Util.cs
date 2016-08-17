using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalClient.HelperUtil
{
    public class Util
    {
        internal static Bitmap resizeImage(Image image, int width, int hegith)
        {
            return new Bitmap(image, width, hegith);
        }
    }

    public class Coordinate
    {
        public int X { get; set; } // Rows
        public int Y { get; set; } // Columns

        public override bool Equals(object obj)
        {
            if (obj is Coordinate)
            {
                Coordinate other = (Coordinate)obj;
                return (X == other.X && Y == other.Y);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() & Y.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("(X = {0,3}, Y = {1,3})", X, Y);
        }

        public static implicit operator Coordinate(CheckersService.Coordinate v)
        {
            if (v == null) return null;
            return new Coordinate
            {
                X = v.X,
                Y = v.Y
            };
        }

        public static implicit operator CheckersService.Coordinate(Coordinate v)
        {
            if (v == null) return null;
            return new CheckersService.Coordinate
            {
                X = v.X,
                Y = v.Y
            };
        }

    }
}
