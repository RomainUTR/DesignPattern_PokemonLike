using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker 
{
    [Header("Settings")]
    private Stack<ICommand> CommandsStack = new Stack<ICommand>();

    //[Header(""References"")]
    //[Header(""Input"")]
    //[Header(""Output"")]

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        CommandsStack.Push(command);
    }

    public void UndoCommand()
    {
        if (CommandsStack.Count > 0)
        {
            ICommand command = CommandsStack.Pop();
            command.Undo();
        }
    }
}