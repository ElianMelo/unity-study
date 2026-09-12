using UnityEngine;

namespace UnityStudy.DesignPatterns.Flyweight
{
    public class ShipFactory : MonoBehaviour
    {
        [SerializeField] private Ship shipPrefab;
        [SerializeField] private ShipData sharedShipData;
        [SerializeField] private float spacing = 1f;

        private void Start()
        {
            GenerateShips(10, 10);
        }

        public void GenerateShips(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Vector3 position = new Vector3(i * spacing, 0, j * spacing);
                    Ship newShip = Instantiate(shipPrefab, position, Quaternion.identity, transform);
                    newShip.Initialize(sharedShipData, 100);
                    // Assuming 100 is the starting health
                    newShip.name = $"Ship_{i * columns + j}";
                }
            }
        }
    }
}
