using System;

namespace Geometry
{
    public class Line
    {
        public virtual LineType Type => GetLineType();
        
        public virtual float? K => CalculateSlope();

        private readonly Point _pStart;
        private readonly Point _pEnd;

        public static Line Make(Point start, Point end)
        {
            ValidatePoints(start, end);

            return start.Y.Equals(end.Y) ? new VerticalLine(start, end) : new Line(start, end);
        }
        
        private static void ValidatePoints(Point start, Point end)
        {
            if (!start.Equals(end)) return;
            throw new ArgumentException("Points should not be equal!");
        }
        
        protected Line(Point start, Point end)
        {
            _pStart = start;
            _pEnd = end;
        }

        public bool IsParallel(Line other)
        {
            return K.Equals(other.K);
        }
        
        private LineType GetLineType()
        {
            return _pStart.X.Equals(_pEnd.X) ? LineType.Horizontal : LineType.Slope;
        }

        private float CalculateSlope()
        {
            if (Type == LineType.Horizontal) return 0;

            float dx = _pStart.X - _pEnd.X;
            float dy = _pStart.Y - _pEnd.Y;

            return dy / dx;
        }
    }
}
