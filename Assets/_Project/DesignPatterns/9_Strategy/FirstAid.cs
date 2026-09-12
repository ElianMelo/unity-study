using UnityEngine;

namespace UnityStudy.DesignPatterns.Strategy
{
    [CreateAssetMenu(fileName = "FirstAidAbility", menuName = "Abilities/FirstAid")]
    public class FirstAid : Ability
    {
        public override void Use(GameObject gameObject)
        {
            Debug.Log("Using First Aid");
            // Implement First Aid/Healing logic here
        }
    }
}
