using UnityEngine;

namespace UnityStudy.Solid.OpenClose
{
    public class AreaCalculator : MonoBehaviour
    {
        public float GetArea(Shape shape)
        {
            return shape.CalculateArea();
        }

        private void Start()
        {
            Debug.Log(GetArea(new Rectangle { width = 2, height = 3 }));
            Debug.Log(GetArea(new Circle { radius = 3 }));
        }
    }

    public class Rectangle : Shape
    {
        public float width;
        public float height;

        public override float CalculateArea()
        {
            return width * height;
        }
    }
    public class Circle : Shape
    {
        public float radius;

        public override float CalculateArea()
        {
            return radius * radius * Mathf.PI;
        }
    }

    public abstract class Shape
    {
        public abstract float CalculateArea();
    }
}

