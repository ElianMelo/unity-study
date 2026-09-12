using UnityEngine;

namespace UnityStudy.DesignPatterns.Flyweight
{
    // Flyweight object (ScriptableObject)
    [CreateAssetMenu]
    public class FactionData : ScriptableObject
    {
        public string factionName;
        public Sprite factionIcon;
        public int baseHealth;
        public int baseAttack;
        public int baseDefense;
        public int baseMovement;
    }
}
