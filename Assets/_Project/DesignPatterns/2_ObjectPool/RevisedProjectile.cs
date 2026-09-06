using UnityEngine;
using UnityEngine.Pool;

namespace UnityStudy.DesignPatterns.ObjectPool
{
    public class RevisedProjectile : MonoBehaviour
    {
        private IObjectPool<RevisedProjectile> objectPool;
        public IObjectPool<RevisedProjectile> ObjectPool { set => objectPool = value; }
    }
}
