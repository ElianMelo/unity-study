using UnityEngine;

namespace UnityStudy.DesignPatterns.DirtyFlag
{
    public class Sector : MonoBehaviour
    {
        [Tooltip("Minimum distance to load")]
        public float m_LoadRadius;
        public Vector3 m_CenterOffset;
        public bool IsLoaded { get; private set; } = false;
        public bool IsDirty { get; private set; } = false;

        private void Awake()
        {
            Clean();
            IsLoaded = false;
        }
        public bool IsPlayerClose(Vector3 playerPosition)
        {
            return Vector3.Distance(playerPosition, transform.position + m_CenterOffset) <= m_LoadRadius;
        }
        public void MarkDirty()
        {
            IsDirty = true;
            Debug.Log($"Sector {gameObject.name} is marked dirty");
        }
        public void Clean()
        {
            IsDirty = false;
        }

        public void LoadContent()
        {
            IsLoaded = true;
            // Logic to load scene content from the project
        }

        public void UnloadContent()
        {
            IsLoaded = false;
            // Logic to unload scene content
        }
    }
}
