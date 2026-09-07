using System;
using UnityEngine;

namespace UnityStudy.DesignPatterns.Observer
{
    public class Subject : MonoBehaviour
    {
        public event Action ThingHappened;

        public void DoThing()
        {
            ThingHappened?.Invoke();
        }
    }
}
