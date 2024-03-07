using NUnit.Framework;
using NUnit.Framework.Legacy;
namespace Test_Area.Tests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double area = triangle.GetArea();
            ClassicAssert.AreEqual(6, area);
        }

        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            double area = circle.GetArea();
            ClassicAssert.AreEqual(78.53981633974483, area);
        }

        [Test]
        public void TriangleIsRightAngle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool isRightAngle = triangle.IsRightAngle();
            ClassicAssert.True(isRightAngle);
        }
    }
}
