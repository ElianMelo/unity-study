using UnityEngine;

namespace UnityStudy.Solid.DependencyInversion
{
    public class SwitchUnrefactored : MonoBehaviour
    {
        public DoorUnrefactored door;
        public bool isActivated;

        public void Toggle()
        {
            if(isActivated)
            {
                isActivated = false;
                door.Close();
            } else
            {
                isActivated = true;
                door.Close();
            }
        }
    }
}
