
using UnityEngine;
namespace Solid.OpenClosed
{
    public class Circle : Shape
    {
        private float _radius;
        public Circle(float radius)
        {
            _radius = radius;
        }
        public override float CalculateArea()
        {
            return _radius * _radius * Mathf.PI;
        }
    }
}