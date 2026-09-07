using UnityEngine;

namespace UnityStudy.DesignPatterns.State
{
    public enum PlayerControllerState { 
        Idle, 
        Walk, 
        Jump
    }

    public class UnrefactoredPlayerController : MonoBehaviour
    {
        private PlayerControllerState state;

        private void Update()
        {
            GetInput();

            switch (state)
            {
                case PlayerControllerState.Idle:
                    Idle();
                    break;
                case PlayerControllerState.Walk:
                    Walk();
                    break;
                case PlayerControllerState.Jump:
                    Jump();
                    break;
                default:
                    break;
            }
        }

        private void GetInput()
        {
            // Process walk and jump controls
        }

        private void Idle()
        {
            // Idle logic
        }

        private void Walk()
        {
            // Walk logic
        }

        private void Jump() { 
            // Jump logic
        }
    }
}
