using System;
using UnityEngine;

namespace UnityStudy.DesignPatterns.ModelViewPresenter
{
    [CreateAssetMenu(fileName = "HealthData", menuName = "DesignPatterns/MVP/HealthModel")]
    public class HealthModel : ScriptableObject
    {
        public event Action HealthChanged;

        public int CurrentHealth;
        public int MaxHealth;
        public string lableName;

        public void Increment(int amount) {
            CurrentHealth += amount;
            HealthChanged?.Invoke();
        }
        public void Decrement(int amount) {
            CurrentHealth -= amount;
            HealthChanged?.Invoke();
        }
        public void Restore() {
            CurrentHealth = MaxHealth;
            HealthChanged?.Invoke();
        }
    }
}
