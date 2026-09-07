using System.Collections.Generic;
using UnityEngine;

namespace UnityStudy.DesignPatterns.Command
{
    public class CommandInvoker : MonoBehaviour
    {
        private static Stack<ICommand> undoStack = new Stack<ICommand>();

        public static void ExecuteCommand(ICommand command)
        {
            command.Execute();
            undoStack.Push(command);
        }

        public static void UndoCommand()
        {
            if(undoStack.Count > 0)
            {
                ICommand activeCommand = undoStack.Pop();
                activeCommand.Undo();
            }
        }
    }
}
