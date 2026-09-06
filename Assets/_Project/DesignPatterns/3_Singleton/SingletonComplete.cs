using UnityEngine;

namespace UnityStudy.DesignPatterns.Singleton
{
    public class SingletonComplete : MonoBehaviour
    {
        private static SingletonComplete instance;
        public static SingletonComplete Instance
        {
            get
            {
                if(instance == null)
                {
                    SetupInstance();
                }
                return instance;
            }
        }

        private void Awake()
        {
            if(instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            } else
            {
                Destroy(gameObject);
            }
        }

        private static void SetupInstance()
        {
            instance = FindAnyObjectByType<SingletonComplete>();
            if(instance == null)
            {
                GameObject gameObj = new GameObject();
                gameObj.name = "Singleton";
                instance = gameObj.AddComponent<SingletonComplete>();
                DontDestroyOnLoad(gameObj);
            }
        }
    }
}
