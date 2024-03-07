namespace Test_Area
{
    public class Circle : ShapeAbstract
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double GetArea() => Math.PI * _radius * _radius;
    }
}
