using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private PlayerController Player;

    private CommandInvoker invoker = new CommandInvoker();

    //[Header("Input")]
    //[Header("Output")]

    public void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();

        Debug.Log(v);

        if (v == Vector2.up)
        {
            invoker.ExecuteCommand(new MoveUpCommand(Player));
        }
        else if (v == Vector2.down)
        {
            invoker.ExecuteCommand(new MoveDownCommand(Player));
        } else if (v == Vector2.left)
        {
            invoker.ExecuteCommand(new MoveLeftCommand(Player));
        }
        else if (v == Vector2.right)
        {
            invoker.ExecuteCommand(new MoveRightCommand(Player));
        }
    }

    public void OnUndo(InputValue value)
    {
        if(value.isPressed)
        {
            invoker.UndoCommand();
        }
    }
}