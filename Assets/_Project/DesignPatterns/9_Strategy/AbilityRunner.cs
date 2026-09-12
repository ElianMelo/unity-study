using UnityEngine;

namespace UnityStudy.DesignPatterns.Strategy
{
    public class AbilityRunner : MonoBehaviour
    {
        public Ability currentAbility;

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                currentAbility.Use(gameObject);
            }        
        }
    }
}
    