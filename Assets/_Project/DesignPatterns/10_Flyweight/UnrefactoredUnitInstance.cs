using UnityEngine;

namespace UnityStudy.DesignPatterns.Flyweight
{
    public class UnrefactoredUnitInstance : MonoBehaviour
    {
        public string factionName;
        public Sprite factionIcon;
        public int baseHealth;
        public int baseAttack;
        public int baseDefense;
        public int baseMovement;

        // Unique state for this unit instance
        public int health;
        public int attack;
        public int defense;
        public int movement;
        public Vector3 position;

        private void Start()
        {
            RefreshUnitStats();
        }

        private void RefreshUnitStats()
        {
            health = baseHealth;
            attack = baseAttack;
            defense = baseDefense;
            movement = baseMovement;
            // ... update other unit components based on faction data
        }

        public void SetFactionData(string factionName, Sprite factionIcon, 
            int baseHealth, int baseAttack, int baseDefense, int baseMovement)
        {
            this.factionName = factionName;
            this.factionIcon = factionIcon;
            this.baseHealth = baseHealth;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseMovement = baseMovement;

            RefreshUnitStats();
        }
    }
}
