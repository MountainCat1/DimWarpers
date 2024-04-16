


using System;
using UnityEngine;
using UnityEngine.InputSystem;

public interface IInputManager
{
}

public class InputManager : MonoBehaviour, IInputManager
{
    private void Awake()
    {
        var inputActions = new InputActions();
        inputActions.Enable();
        inputActions.Player.Movement.performed += OnMovementOnperformed;
    }

    private void OnMovementOnperformed(InputAction.CallbackContext ctx)
    {
        Debug.Log(ctx.ReadValue<Vector2>());
    }
}