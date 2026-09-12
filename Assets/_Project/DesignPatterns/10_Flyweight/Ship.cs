using UnityEngine;

namespace UnityStudy.DesignPatterns.Flyweight
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private ShipData m_SharedData;
        [SerializeField] private float m_Health;

        public void Initialize(ShipData data, float health)
        {
            m_SharedData = data;
            m_Health = health;
        }

        public void DisplayShipInfo()
        {
            Debug.Log($"Name: {m_SharedData.UnitName}, Health: {m_Health}");
        }
    }
}
