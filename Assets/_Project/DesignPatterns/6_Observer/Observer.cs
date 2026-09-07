using UnityEngine;

namespace UnityStudy.DesignPatterns.Observer
{
    public class Observer : MonoBehaviour
    {
        [SerializeField] private Subject subjectToObserve;

        private void OnThingHappened()
        {
            // Any logic that responds to event goes here
            Debug.Log("Observer responds");
        }

        private void OnEnable()
        {
            if(subjectToObserve != null)
            {
                subjectToObserve.ThingHappened += OnThingHappened;
            }
        }

        private void OnDisable()
        {
            if(subjectToObserve != null)
            {
                subjectToObserve.ThingHappened -= OnThingHappened;
            }
        }
    }
}
