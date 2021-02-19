using System;
using NUnit.Framework;
using Geometry;

using static NUnit.Framework.Assert;

namespace GeometryTests
{
    public class Tests
    {
        private Point _p1;
        private Point _p2;
        private Point _p3;
        private Point _p4;
        private Point _p5;
        private Point _p6;

        private Line _l1;
        private Line _l2;
        private Line _l3;
        private Line _l4;
        private Line _l5;
        private Line _l6;

        [SetUp]
        public void Setup()
        {
            _p1 = new Point(2, 4);
            _p2 = new Point(2, 4);
            _p3 = new Point(0, 0);
            _p4 = new Point(2, 2);
            _p5 = new Point(0, 4);
            _p6 = new Point(4, 4);
            _l1 = Line.Make(_p1, _p3);
            _l2 = Line.Make(_p1, _p4);
            _l3 = Line.Make(_p1, _p5);
            _l4 = Line.Make(_p4, _p6);
            _l5 = Line.Make(_p5, _p6);
            _l6 = Line.Make(_p3, _p4);
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
        public void TestPointsEquality()
        {
            AreEqual(_p1, _p2);
        }
        
        [Test]
        public void TestPointString()
        {
            const string pStr = "(2; 4)";
            AreEqual(pStr, _p1.ToString());
        }

        [Test]
        public void TestLineConstructor()
        {
            Throws<ArgumentException>(() => Line.Make(_p1, _p2));
        }

        [Test]
        public void TestLineType()
        {
            AreEqual(LineType.Slope, _l1.Type);
            AreEqual(LineType.Horizontal, _l2.Type);
            AreEqual(LineType.Vertical, _l3.Type);
            AreEqual(LineType.Vertical, _l5.Type);
        }

        [Test]
        public void TestSlope()
        {
            AreEqual(0, _l2.K);
            AreEqual(1, _l4.K);
            AreEqual(2, _l1.K);
            
            IsNull(_l3.K);
        }

        [Test]
        public void TestParallelLines()
        {
            IsTrue(_l3.IsParallel(_l5));
            IsTrue(_l5.IsParallel(_l3));
            IsTrue(_l4.IsParallel(_l6));
            IsFalse(_l2.IsParallel(_l1));
        }
    }
}
