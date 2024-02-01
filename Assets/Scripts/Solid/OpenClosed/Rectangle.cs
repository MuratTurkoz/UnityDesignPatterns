
namespace Solid.OpenClosed
{
    public class Rectangle : Shape
    {
        private float _width;
        private float _height;
        public Rectangle(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public override float CalculateArea()
        {
            return _width * _height;
        }
    }
}
