using UnityEngine;

namespace UnityStudy.Solid.DependencyInversion
{
    public class DoorUnrefactored : MonoBehaviour
    {
        public void Open()
        {
            Debug.Log("The door is open.");
        }

        public void Close()
        {
            Debug.Log("The door is closed.");
        }
    }
}
