using UnityEngine;

namespace UnityStudy.DesignPatterns.Strategy
{
    [CreateAssetMenu(fileName = "AirSupportAbility", menuName = "Abilities/AirSupport")]
    public class AirSupport : Ability
    {
        public override void Use(GameObject gameObject)
        {
            Debug.Log("Calling in Air Support");
            // Implement Air Support logic here
        }
    }
}
