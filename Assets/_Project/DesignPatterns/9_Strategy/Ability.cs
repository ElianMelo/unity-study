using UnityEngine;

namespace UnityStudy.DesignPatterns.Strategy
{
    public abstract class Ability : ScriptableObject
    {
        public string abilityName;
        public abstract void Use(GameObject gameObject);
    }
}
