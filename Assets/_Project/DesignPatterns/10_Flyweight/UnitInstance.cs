using UnityEngine;

namespace UnityStudy.DesignPatterns.Flyweight
{
    // Context object
    public class UnitInstance : MonoBehaviour
    {
        public FactionData factionData;
        private void Start()
        {
            RefreshUnitStats();
        }

        private void RefreshUnitStats()
        {
            health = factionData.baseHealth;
            attack = factionData.baseAttack;
            defense = factionData.baseDefense;
            movement = factionData.baseMovement;
            // ... Update other unit components based on faction data
        }

        // Unique state for this unit instance
        public int health;
        public int attack;
        public int defense;
        public int movement;

        public Vector3 position;
        // ... Add other unique states here
    }
}
