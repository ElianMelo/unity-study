using UnityEngine;

namespace UnityStudy.DesignPatterns.Strategy
{
    public class AbilityRunnerUnrefactored : MonoBehaviour
    {
        public enum Ability
        {
            RadarPulse,
            AirSupport,
            FirstAid
        }

        public Ability ability;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                ActiveteAbility(ability);
            }
        }

        void ActiveteAbility(Ability ability)
        {
            switch (ability)
            {
                case Ability.RadarPulse:
                    // Radar Pulse Logic
                    Debug.Log("Activating Radar Pulse");
                    break;
                case Ability.AirSupport:
                    // Air Support Logic
                    Debug.Log("Calling in Air Support");
                    break;
                case Ability.FirstAid:
                    // First Aid/Healing Logic
                    Debug.Log("Using First Aid");
                    break;
                default:
                    break;
            }
        }
    }
}
