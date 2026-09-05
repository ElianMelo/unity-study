using UnityEngine;

namespace UnityStudy.DesignPatterns.Factory
{
    public interface IProduct
    {
        public string ProductName { get; set; }
        public void Initialize();
    }

    public abstract class Factory : MonoBehaviour
    {
        public abstract IProduct GetProduct(Vector3 position);

        // Shared method with all factories
    }
}
