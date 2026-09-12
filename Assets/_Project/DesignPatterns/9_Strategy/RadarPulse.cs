using UnityEngine;

namespace UnityStudy.DesignPatterns.Strategy
{
    [CreateAssetMenu(fileName = "RadarPulseAbility", menuName = "Abilities/RadarPulse")]
    public class RadarPulse : Ability
    {
        public override void Use(GameObject gameObject)
        {
            Debug.Log("Activating Radar Pulse");
            // Implement Radar Pulse logic here
        }
    }
}
