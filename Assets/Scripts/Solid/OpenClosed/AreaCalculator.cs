using UnityEngine;

namespace Solid.OpenClosed
{
    public class AreaCalculator : MonoBehaviour
    {
        public float GetArea(Shape shape)
        {
            return shape.CalculateArea();
        }

        private void Start()
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Circle circle = new Circle(5);
            Debug.Log($"Rectangel Area:{GetArea(rectangle)}");
            Debug.Log($"Circle Area:{GetArea(circle)}");
        }
    }
}




