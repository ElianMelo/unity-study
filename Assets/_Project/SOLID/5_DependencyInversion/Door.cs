using UnityEngine;

namespace UnityStudy.Solid.DependencyInversion
{
    public class Door : MonoBehaviour, ISwitchable
    {
        private bool isActive;
        public bool IsActive => isActive;

        public void Activate()
        {
            isActive = true;
            Debug.Log("The door is open.");
        }

        public void Deactivate()
        {
            isActive = false;
            Debug.Log("The door is closed.");
        }
    }
}
