using NUnit.Framework;
using Geometry;

using static NUnit.Framework.Assert;

namespace GeometryTests
{
    public class Tests
    {
        private Point _p1;
        private Point _p2;
        
        [SetUp]
        public void Setup()
        {
            _p1 = new Point(2, 4);
            _p2 = new Point(2, 4);
        }

        [Test]
        public void TestCoordinates()
        {
            const int x = 2;
            const int y = 4;

            AreEqual(x, _p1.X);
            AreEqual(y, _p1.Y);
        }

        [Test]
        public void TestComparison()
        {
            AreEqual(_p1, _p2);
        }
        
        [Test]
        public void TestPointString()
        {
            const string pStr = "(2; 4)";
            AreEqual(pStr, _p1.ToString());
        }
    }
}
