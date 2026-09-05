using UnityEngine;

namespace UnityStudy.Solid.LiskovSubstitution
{
    public class Navigator : MonoBehaviour
    {
        public void Move(Vehicle vehicle)
        {
            vehicle.GoForward();
            vehicle.TurnLeft();
            vehicle.GoForward();
            vehicle.TurnRight();
            vehicle.GoForward();
        }
    }
}