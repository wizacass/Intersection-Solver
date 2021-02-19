namespace Geometry
{
    public class VerticalLine: Line
    {
        public override LineType Type => LineType.Vertical;
        public override float? K => null;

        protected internal VerticalLine(Point start, Point end) : base(start, end) { }
    }
}
