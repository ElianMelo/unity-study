using UnityEngine;

namespace UnityStudy.Solid.SingleResponsability
{
    public class UnrefactoredPlayer : MonoBehaviour
    {
        [SerializeField] private string inputAxisName;
        [SerializeField] private float positionMultiplier;
        private float yPosition;
        private AudioSource bounceSfx;

        // Break into smaller classes
        void Start()
        {
            bounceSfx = GetComponent<AudioSource>();
        }

        // manages input, handle movement
        void Update()
        {
            float delta = Input.GetAxis(inputAxisName) * Time.deltaTime;

            yPosition = Mathf.Clamp(yPosition + delta, -1, 1);
            transform.position = new Vector3(transform.position.x, yPosition * positionMultiplier, transform.position.z);
        }

        // Plays sound when a player collides with something
        private void OnTriggerEnter(Collider other)
        {
            bounceSfx.Play();
        }
    }
}

