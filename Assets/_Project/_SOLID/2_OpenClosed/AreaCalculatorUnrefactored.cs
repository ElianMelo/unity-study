using UnityEngine;

namespace UnityStudy.Solid.OpenClose
{
    public class AreaCalculatorUnrefactored : MonoBehaviour
    {
        public float GetRectanbleArea(RectangleUnrefactored rectangle)
        {
            return rectangle.width * rectangle.height;
        }

        public float GetCircleArea(CircleUnrefactored circle)
        {
            return circle.radius * circle.radius * Mathf.PI;
        }
    }

    public class RectangleUnrefactored
    {
        public float width;
        public float height;
    }
    public class CircleUnrefactored
    {
        public float radius;
    }
}

