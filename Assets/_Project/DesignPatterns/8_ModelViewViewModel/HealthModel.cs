using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityStudy.DesignPatterns.ModelViewViewModel
{
    [CreateAssetMenu(fileName = "HealthData", menuName = "DesignPatterns/MVVM/HealthModel")]
    public class HealthModel : ScriptableObject
    {
        public int CurrentHealth;
        public int MaxHealth;
        public string lableName;

        static int k_MaxHealth;

        [InitializeOnLoadMethod]
        public static void RegisterConverters()
        {
            var converter = new ConverterGroup("Int to HealthBar");

            converter.AddConverter((ref int value) => 
                new StyleColor(Color.Lerp(Color.red, Color.green, value / (float)k_MaxHealth)));

            converter.AddConverter((ref int value) =>
            {
                float healhtRatio = (float)value / (float)k_MaxHealth;
                return healhtRatio switch
                {
                    >= 0f and < 1f / 3f => "Danger",
                    >= 1f / 3f and < 2f / 3f => "Neutral",
                    _ => "Good"
                };
            });
            ConverterGroups.RegisterConverterGroup(converter);
        }

        public void Increment(int amount) {
            CurrentHealth += amount;
        }
        public void Decrement(int amount) {
            CurrentHealth -= amount;
        }
        public void Restore() {
            CurrentHealth = MaxHealth;
        }
    }
}
