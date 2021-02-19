using System;

namespace Geometry
{
    public class Point: IEquatable<Point>
    {
        public float X { get; }
        public float Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}; {Y})";
        }

        public bool Equals(Point other)
        {
            if (other == null) return false;
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override bool Equals(object obj)
        {
            if (obj is Point p) return Equals(p);
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
