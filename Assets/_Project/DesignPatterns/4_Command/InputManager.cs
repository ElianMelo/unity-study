using UnityEngine;

namespace UnityStudy.DesignPatterns.Command
{
    public class InputManager : MonoBehaviour
    {
        PlayerMover playerMover;
        Vector3 movement;

        private void Awake()
        {
            RunPlayerCommand(playerMover, movement);
        }

        private void RunPlayerCommand(PlayerMover playerMover, Vector3 movement)
        {
            if(playerMover == null)
            {
                return;
            }
            if(playerMover.IsValidMove(movement))
            {
                ICommand command = new MoveCommand(playerMover, movement);
                CommandInvoker.ExecuteCommand(command);
            }
        }
    }
}
