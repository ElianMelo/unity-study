using UnityEngine;

namespace UnityStudy.Solid.DependencyInversion
{
    public class Switch : MonoBehaviour
    {
        public ISwitchable client;
        public void Toggle()
        {
            if(client.IsActive)
            {
                client.Deactivate();
            } else
            {
                client.Activate();
            }
        }
    }
}