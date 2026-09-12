using UnityEngine;

namespace UnityStudy.DesignPatterns.Flyweight
{
    [CreateAssetMenu(fileName = "ShipData", menuName = "Flyweight/ShipData", order = 1)]
    public class ShipData : ScriptableObject
    {
        public string UnitName;
        public string Description;
        public float Speed;
        public int AttackPower;
        public int Defense;
    }
}
